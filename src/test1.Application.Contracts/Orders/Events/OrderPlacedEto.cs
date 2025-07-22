using System;

namespace test1.Orders.Events;

public class OrderPlacedEto
{
    public string CustomerName { get; set; }
    public Guid ProductId { get; set; }
}