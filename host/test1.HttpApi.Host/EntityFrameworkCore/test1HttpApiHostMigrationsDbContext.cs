using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace test1.EntityFrameworkCore;

public class test1HttpApiHostMigrationsDbContext : AbpDbContext<test1HttpApiHostMigrationsDbContext>
{
    public test1HttpApiHostMigrationsDbContext(DbContextOptions<test1HttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Configuretest1();
    }
}
