using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace test1.Orders.Manager;

public class OrderManager :DomainService
{
    private readonly IRepository<Order, Guid> _orderRepository;

    public OrderManager(IRepository<Order, Guid> orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task InsertOrderAsync(Order order)
    {
        await _orderRepository.InsertAsync(order);
    }  
}