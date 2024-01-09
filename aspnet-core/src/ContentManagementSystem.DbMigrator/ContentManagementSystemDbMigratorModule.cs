using ContentManagementSystem.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;

namespace ContentManagementSystem.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(ContentManagementSystemEntityFrameworkCoreModule),
    typeof(ContentManagementSystemApplicationContractsModule)
    )]
public class ContentManagementSystemDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "ContentManagementSystem:"; });
    }
}
