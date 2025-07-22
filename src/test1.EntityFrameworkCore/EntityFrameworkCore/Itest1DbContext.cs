using Microsoft.EntityFrameworkCore;
using test1.Orders;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace test1.EntityFrameworkCore;

[ConnectionStringName(test1DbProperties.ConnectionStringName)]
public interface Itest1DbContext : IEfCoreDbContext
{
    DbSet<Order> Orders { get; set; }

}
