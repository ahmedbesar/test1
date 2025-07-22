using test1.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace test1;

public abstract class test1Controller : AbpControllerBase
{
    protected test1Controller()
    {
        LocalizationResource = typeof(test1Resource);
    }
}
