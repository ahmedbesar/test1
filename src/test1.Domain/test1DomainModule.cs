using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace test1;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(test1DomainSharedModule)
)]
public class test1DomainModule : AbpModule
{

}
