using Azure.Messaging.ServiceBus;


namespace BackOffice.DataStuff.Interfaces;

    public interface IServiceBusTransaction<Transaction>
    {
            Task SendMessageAsync(Transaction message);
            void RegisterMessageHandler(Func<ProcessMessageEventArgs, Task> messageHandler, Func<ProcessErrorEventArgs, Task>? errorHandler = null);
            Task StartProcessingAsync(CancellationToken cancellationToken);
            Task StopProcessingAsync(CancellationToken cancellationToken);

    }

