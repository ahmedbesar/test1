using Volo.Abp.Bundling;

namespace test1.Blazor.Host.Client;

public class test1BlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
