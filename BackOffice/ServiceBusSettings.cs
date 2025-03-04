namespace BackOffice
{
    public class TransactionSettings
    {
        public required string ServiceBusConnectionString { get; set; }
        public required string SubscriptionName { get; set; }
        public required string DatabaseConnectionString { get; set; }
    }
}
