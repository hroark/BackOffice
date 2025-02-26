using Azure.Messaging.ServiceBus;
using BackOffice.Models.Stations.Interfaces;
using System.Text.Json;

namespace BackOffice
{
    public class ServiceBusTransaction<TTransaction> where TTransaction : class, ITransaction<TTransaction>
    {
        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
        public TTransaction FromJson(string json)
        {
            return JsonSerializer.Deserialize<TTransaction>(json) ?? throw new InvalidOperationException("Json invalid for deserialization");
        }
        public void SaveToDatabase(TTransaction item)
        {
            throw new NotImplementedException();
        }

        private readonly ILogger<ServiceBusTransaction<TTransaction>> _logger;
        private readonly ServiceBusSender _serviceBusSender;
        private readonly ServiceBusProcessor _serviceBusProcessor;

        private const string connectionString = "<connection_string>";
        private const string topicName = "<topic_name>";
        private const string subscriptionName = "<subscription_name>";
        public ServiceBusTransaction(TransactionSettings serviceBusSettings, ILogger<ServiceBusTransaction<TTransaction>> logger)
        {
            _logger = logger;
            var topicType = typeof(TTransaction);
            var topic = topicType.Name.ToLower();
            var serviceBusClient = new ServiceBusClient(serviceBusSettings.ServiceBusConnectionString);
            _serviceBusSender = serviceBusClient.CreateSender(topic);
            _serviceBusProcessor =
                serviceBusClient.CreateProcessor(topic, serviceBusSettings.SubscriptionName, new ServiceBusProcessorOptions()); // You can customize options
        }

        public async Task SendMessageAsync(TTransaction message)
        {
            var msgJson = message.ToJson();
            msgJson = JsonSerializer.Serialize(message);
            ServiceBusMessage msg = new ServiceBusMessage(msgJson);
            await _serviceBusSender.SendMessageAsync(msg);
        }

        public void RegisterMessageHandler(Func<ProcessMessageEventArgs, Task> messageHandler, Func<ProcessErrorEventArgs, Task>? errorHandler = null)
        {
            _serviceBusProcessor.ProcessMessageAsync += messageHandler;
            if (errorHandler == null)
                _serviceBusProcessor.ProcessErrorAsync += ErrorHandler;
            else
                _serviceBusProcessor.ProcessErrorAsync += errorHandler;

            _serviceBusProcessor.StartProcessingAsync();
        }

        public async Task StartProcessingAsync(CancellationToken cancellationToken)
        {
            await _serviceBusProcessor.StartProcessingAsync(cancellationToken);
        }

        public async Task StopProcessingAsync(CancellationToken cancellationToken)
        {
            await _serviceBusProcessor.StopProcessingAsync(cancellationToken);
        }

        private Task ErrorHandler(ProcessErrorEventArgs arg)
        {
            _logger.LogError(arg.Exception.Message);

            return Task.CompletedTask;
        }
    }
}
