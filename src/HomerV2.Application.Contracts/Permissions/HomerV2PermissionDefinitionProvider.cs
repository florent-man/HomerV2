using HomerV2.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace HomerV2.Permissions;

public class HomerV2PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HomerV2Permissions.GroupName);

        myGroup.AddPermission(HomerV2Permissions.Dashboard.Host, L("Permission:Dashboard"), MultiTenancySides.Host);
        myGroup.AddPermission(HomerV2Permissions.Dashboard.Tenant, L("Permission:Dashboard"), MultiTenancySides.Tenant);

        var applicationPermission = myGroup.AddPermission(HomerV2Permissions.Application.Default, L("Permission:Application"));
        applicationPermission.AddChild(HomerV2Permissions.Application.Create, L("Permission:Create"));
        applicationPermission.AddChild(HomerV2Permissions.Application.Update, L("Permission:Update"));
        applicationPermission.AddChild(HomerV2Permissions.Application.Delete, L("Permission:Delete"));
        
        //Define your own permissions here. Example:
        //myGroup.AddPermission(HomerV2Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HomerV2Resource>(name);
    }
}
