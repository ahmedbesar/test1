namespace test1.Orders.Jobs;

public class CreateOrderLogArgs
{
    
    public string LogMessage { get; set; }

    public static CreateOrderLogArgs CreateLogMessage(string customerName)
    {
        return new CreateOrderLogArgs
        {
            LogMessage = $"Order has been created for customer {customerName}"
        };
    }
}