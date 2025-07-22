using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace test1;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(test1HttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class test1ConsoleApiClientModule : AbpModule
{

}
