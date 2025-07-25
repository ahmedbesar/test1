using System;
using Volo.Abp.EventBus;

namespace test1.Orders.Events;

[EventName("OrderCreated")]
public class OrderPlacedEto
{
    public string CustomerName { get; set; }
    public Guid ProductId { get; set; }
}