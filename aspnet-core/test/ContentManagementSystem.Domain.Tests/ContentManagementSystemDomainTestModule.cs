using Volo.Abp.Modularity;

namespace ContentManagementSystem;

[DependsOn(
    typeof(ContentManagementSystemDomainModule),
    typeof(ContentManagementSystemTestBaseModule)
)]
public class ContentManagementSystemDomainTestModule : AbpModule
{

}
