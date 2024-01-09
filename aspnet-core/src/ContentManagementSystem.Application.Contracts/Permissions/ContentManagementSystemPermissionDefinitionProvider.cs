using ContentManagementSystem.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ContentManagementSystem.Permissions;

public class ContentManagementSystemPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ContentManagementSystemPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ContentManagementSystemPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ContentManagementSystemResource>(name);
    }
}
