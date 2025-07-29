using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.EventBus.RabbitMq;
using Volo.Abp.BackgroundJobs.Hangfire;

namespace test1;

[DependsOn(
    typeof(test1DomainModule),
    typeof(test1ApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
[DependsOn(typeof(AbpEventBusRabbitMqModule))]
    [DependsOn(typeof(AbpBackgroundJobsHangfireModule))]
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
