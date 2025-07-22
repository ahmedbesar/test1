using System.Collections.Generic;
using System.Threading.Tasks;
using test1.Orders.Dtos;
using Volo.Abp.Application.Services;

namespace test1.Orders.Interfaces;

public interface IOrderAppService : IApplicationService
{
    Task<List<OrderDto>> GetListAsync();
    Task CreateAsync(OrderCreationDto input);
}
