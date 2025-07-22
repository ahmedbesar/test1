using Localization.Resources.AbpUi;
using test1.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace test1;

[DependsOn(
    typeof(test1ApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class test1HttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(test1HttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<test1Resource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
