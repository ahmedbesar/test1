using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace test1;

[Dependency(ReplaceServices = true)]
public class test1BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "test1";
}
