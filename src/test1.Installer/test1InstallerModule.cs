using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace test1;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class test1InstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<test1InstallerModule>();
        });
    }
}
