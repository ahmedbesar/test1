using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace test1.EntityFrameworkCore;

public class test1HttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<test1HttpApiHostMigrationsDbContext>
{
    public test1HttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<test1HttpApiHostMigrationsDbContext>()
            .UseNpgsql(configuration.GetConnectionString("test1"));

        return new test1HttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
