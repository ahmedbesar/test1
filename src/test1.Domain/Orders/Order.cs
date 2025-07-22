using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace test1.Orders;

public class Order : CreationAuditedAggregateRoot<Guid>
{
    public Guid ProductId { get; set; }
    public string CustomerName { get; set; }
}