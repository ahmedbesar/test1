using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace test1.Blazor.WebAssembly;

[DependsOn(
    typeof(test1BlazorModule),
    typeof(test1HttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class test1BlazorWebAssemblyModule : AbpModule
{

}
