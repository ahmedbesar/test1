using test1.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace test1.Pages;

public abstract class test1PageModel : AbpPageModel
{
    protected test1PageModel()
    {
        LocalizationResourceType = typeof(test1Resource);
    }
}
