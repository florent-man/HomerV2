using Volo.Abp.Modularity;

namespace HomerV2;

/* Inherit from this class for your domain layer tests. */
public abstract class HomerV2DomainTestBase<TStartupModule> : HomerV2TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
