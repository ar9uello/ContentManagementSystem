using System.Threading.Tasks;

namespace ContentManagementSystem.Data;

public interface IContentManagementSystemDbSchemaMigrator
{
    Task MigrateAsync();
}
