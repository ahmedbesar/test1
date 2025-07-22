using Volo.Abp.Modularity;

namespace test1;

[DependsOn(
    typeof(test1DomainModule),
    typeof(test1TestBaseModule)
)]
public class test1DomainTestModule : AbpModule
{

}
