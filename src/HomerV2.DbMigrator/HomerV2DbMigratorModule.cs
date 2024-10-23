using HomerV2.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace HomerV2.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HomerV2EntityFrameworkCoreModule),
    typeof(HomerV2ApplicationContractsModule)
)]
public class HomerV2DbMigratorModule : AbpModule
{
}
