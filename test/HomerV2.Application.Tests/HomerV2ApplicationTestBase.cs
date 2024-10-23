using Volo.Abp.Modularity;

namespace HomerV2;

public abstract class HomerV2ApplicationTestBase<TStartupModule> : HomerV2TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
