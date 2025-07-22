using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace test1;

[DependsOn(
    typeof(test1ApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class test1HttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(test1ApplicationContractsModule).Assembly,
            test1RemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<test1HttpApiClientModule>();
        });

    }
}
