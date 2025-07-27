using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace test1.Orders;

public class Order : CreationAuditedAggregateRoot<Guid>
{
    public Guid ProductId { get; private set; }
    public string CustomerName { get;private set; }

    public Order()
    {
        
    }
    public Order(Guid productId , string customerName)
    {
        ProductId=productId;
        CustomerName = customerName;
    }
}