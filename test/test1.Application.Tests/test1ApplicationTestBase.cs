using Volo.Abp.Modularity;

namespace test1;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class test1ApplicationTestBase<TStartupModule> : test1TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
