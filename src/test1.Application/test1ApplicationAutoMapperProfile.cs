using AutoMapper;
using test1.Orders;
using test1.Orders.Dtos;
using Volo.Abp.AutoMapper;

namespace test1;

public class test1ApplicationAutoMapperProfile : Profile
{
    public test1ApplicationAutoMapperProfile()
    {
        CreateMap<Order, OrderDto>().Ignore(x=>x.ProductName);
    }
}
