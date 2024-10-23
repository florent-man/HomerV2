using Volo.Abp.Modularity;

namespace HomerV2;

[DependsOn(
    typeof(HomerV2ApplicationModule),
    typeof(HomerV2DomainTestModule)
)]
public class HomerV2ApplicationTestModule : AbpModule
{

}
