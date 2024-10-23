using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HomerV2.Data;
using Volo.Abp.DependencyInjection;

namespace HomerV2.EntityFrameworkCore;

public class EntityFrameworkCoreHomerV2DbSchemaMigrator
    : IHomerV2DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreHomerV2DbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the HomerV2DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<HomerV2DbContext>()
            .Database
            .MigrateAsync();
    }
}
