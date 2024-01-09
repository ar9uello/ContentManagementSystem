using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ContentManagementSystem.Data;

/* This is used if database provider does't define
 * IContentManagementSystemDbSchemaMigrator implementation.
 */
public class NullContentManagementSystemDbSchemaMigrator : IContentManagementSystemDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
