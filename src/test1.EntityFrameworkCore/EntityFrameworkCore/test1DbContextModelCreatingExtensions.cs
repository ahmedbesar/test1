using Microsoft.EntityFrameworkCore;
using test1.Orders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace test1.EntityFrameworkCore;

public static class test1DbContextModelCreatingExtensions
{
    public static void Configuretest1(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Order>(b =>
        {
            b.ToTable("Orders");

            b.ConfigureByConvention();

            b.Property(q => q.CustomerName).IsRequired().HasMaxLength(120);
        });
    }
}
