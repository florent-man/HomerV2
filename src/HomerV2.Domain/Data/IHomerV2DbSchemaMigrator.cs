using System.Threading.Tasks;

namespace HomerV2.Data;

public interface IHomerV2DbSchemaMigrator
{
    Task MigrateAsync();
}
