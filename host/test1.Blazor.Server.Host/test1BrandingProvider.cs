using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace test1.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class test1BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "test1";
}
