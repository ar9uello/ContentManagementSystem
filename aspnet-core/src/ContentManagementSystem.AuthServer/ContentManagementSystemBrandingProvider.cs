using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ContentManagementSystem;

[Dependency(ReplaceServices = true)]
public class ContentManagementSystemBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ContentManagementSystem";
}
