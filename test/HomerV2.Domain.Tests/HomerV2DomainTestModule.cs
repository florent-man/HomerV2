using Volo.Abp.Modularity;

namespace HomerV2;

[DependsOn(
    typeof(HomerV2DomainModule),
    typeof(HomerV2TestBaseModule)
)]
public class HomerV2DomainTestModule : AbpModule
{

}
