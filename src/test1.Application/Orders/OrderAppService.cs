using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test1.Orders.Dtos;
using test1.Orders.Events;
using test1.Orders.Interfaces;
using test1.Orders.Manager;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

namespace test1.Orders;

public class OrderAppService:test1AppService,IOrderAppService
{
    private readonly IRepository<Order, Guid> _orderRepository;
    private readonly OrderManager _orderManager;
    private readonly IDistributedEventBus _distributedEventBus;
    

    public OrderAppService(IRepository<Order, Guid> orderRepository,OrderManager orderManager
        ,IDistributedEventBus distributedEventBus)
    {
        _orderRepository = orderRepository;
        _orderManager = orderManager;
        _distributedEventBus = distributedEventBus;
    }

    public async Task<List<OrderDto>> GetListAsync()
    {
        var orders = await _orderRepository.GetListAsync();
        var orderDtos = ObjectMapper.Map<List<Order>, List<OrderDto>>(orders);
        return orderDtos;

    }

    public async Task CreateAsync(OrderCreationDto input)
    {
        var order = Order.Create(input.ProductId, input.CustomerName);
        
        await _orderManager.InsertOrderAsync(order);
        await _distributedEventBus.PublishAsync(
            new OrderPlacedEto { CustomerName =order.CustomerName,ProductId=order.ProductId});
    }   
}