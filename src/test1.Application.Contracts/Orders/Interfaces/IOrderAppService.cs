using System.Collections.Generic;
using System.Threading.Tasks;
using test1.Orders.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Uow;

namespace test1.Orders.Interfaces;

public interface IOrderAppService : IApplicationService,ITransientDependency
{
    Task<List<OrderDto>> GetListAsync();
    Task CreateAsync(OrderCreationDto input);
}
