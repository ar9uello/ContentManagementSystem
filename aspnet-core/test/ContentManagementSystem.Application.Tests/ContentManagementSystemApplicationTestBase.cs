using Volo.Abp.Modularity;

namespace ContentManagementSystem;

public abstract class ContentManagementSystemApplicationTestBase<TStartupModule> : ContentManagementSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
