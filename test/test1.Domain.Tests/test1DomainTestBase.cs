using Volo.Abp.Modularity;

namespace test1;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class test1DomainTestBase<TStartupModule> : test1TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
