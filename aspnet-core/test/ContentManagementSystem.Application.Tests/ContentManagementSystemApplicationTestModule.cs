using Volo.Abp.Modularity;

namespace ContentManagementSystem;

[DependsOn(
    typeof(ContentManagementSystemApplicationModule),
    typeof(ContentManagementSystemDomainTestModule)
)]
public class ContentManagementSystemApplicationTestModule : AbpModule
{

}
