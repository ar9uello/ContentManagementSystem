using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ContentManagementSystem.Data;
using Volo.Abp.DependencyInjection;

namespace ContentManagementSystem.EntityFrameworkCore;

public class EntityFrameworkCoreContentManagementSystemDbSchemaMigrator
    : IContentManagementSystemDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreContentManagementSystemDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ContentManagementSystemDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ContentManagementSystemDbContext>()
            .Database
            .MigrateAsync();
    }
}
