using Microsoft.EntityFrameworkCore;
using test1.Orders;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace test1.EntityFrameworkCore;

[ConnectionStringName(test1DbProperties.ConnectionStringName)]
public class test1DbContext : AbpDbContext<test1DbContext>, Itest1DbContext
{
    public DbSet<Order> Orders { get; set; }


    public test1DbContext(DbContextOptions<test1DbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Configuretest1();
    }
}
