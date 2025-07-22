using test1.Localization;
using Volo.Abp.Application.Services;

namespace test1;

public abstract class test1AppService : ApplicationService
{
    protected test1AppService()
    {
        LocalizationResource = typeof(test1Resource);
        ObjectMapperContext = typeof(test1ApplicationModule);
    }
}
