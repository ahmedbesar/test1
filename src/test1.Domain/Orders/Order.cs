using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Domain.Values;

namespace test1.Orders;

public class Order : CreationAuditedAggregateRoot<Guid>
{
    public Guid ProductId { get; private set; }
    public string CustomerName { get;private set; }

    private Order()
    {
        
    }
    private Order(Guid productId , string customerName)
    {
        ProductId=productId;
        CustomerName = customerName;
    }
    public static Order Create(Guid productId, string customerName)
    {
        if (string.IsNullOrWhiteSpace(customerName))
            throw new BusinessException("Customer name is required");

        return new Order(productId, customerName);
    }

}