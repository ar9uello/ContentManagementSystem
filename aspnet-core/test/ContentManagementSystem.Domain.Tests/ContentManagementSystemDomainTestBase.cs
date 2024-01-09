using Volo.Abp.Modularity;

namespace ContentManagementSystem;

/* Inherit from this class for your domain layer tests. */
public abstract class ContentManagementSystemDomainTestBase<TStartupModule> : ContentManagementSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
