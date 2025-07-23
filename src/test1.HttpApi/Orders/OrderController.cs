using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using test1.Orders.Dtos;
using test1.Orders.Interfaces;
using Volo.Abp;

namespace test1.Orders;

[Area(test1RemoteServiceConsts.ModuleName)]
[RemoteService(Name = test1RemoteServiceConsts.RemoteServiceName)]
[Route("api/test1/order")]
public class OrderController : test1Controller, IOrderAppService
{
    private readonly IOrderAppService _orderAppService;

    public OrderController(IOrderAppService orderAppService)
    {
        _orderAppService = orderAppService;
    }
    [HttpGet]
    [Route("GetAllOrders")]
    //[Authorize]
    public Task<List<OrderDto>> GetListAsync()
    {
        try
        {
        return _orderAppService.GetListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    [HttpPost]
    [Route("CreateOrder")]
    //[Authorize]
    public Task CreateAsync(OrderCreationDto input)
    {
        try
        {
        return _orderAppService.CreateAsync(input);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}