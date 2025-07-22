using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace test1;

[DependsOn(
    typeof(test1DomainModule),
    typeof(test1ApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class test1ApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<test1ApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<test1ApplicationModule>(validate: true);
        });
    }
}
