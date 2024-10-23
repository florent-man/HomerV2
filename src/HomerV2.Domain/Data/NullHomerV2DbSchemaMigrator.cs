using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HomerV2.Data;

/* This is used if database provider does't define
 * IHomerV2DbSchemaMigrator implementation.
 */
public class NullHomerV2DbSchemaMigrator : IHomerV2DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
