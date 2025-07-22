using test1.Localization;
using Volo.Abp.AspNetCore.Components;

namespace test1.Blazor.Server.Host;

public abstract class test1ComponentBase : AbpComponentBase
{
    protected test1ComponentBase()
    {
        LocalizationResource = typeof(test1Resource);
    }
}
