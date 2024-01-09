using Volo.Abp.Settings;

namespace ContentManagementSystem.Settings;

public class ContentManagementSystemSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ContentManagementSystemSettings.MySetting1));
    }
}
