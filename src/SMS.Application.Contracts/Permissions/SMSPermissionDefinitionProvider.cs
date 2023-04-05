using SMS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace SMS.Permissions;

public class SMSPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var SMSGroup = context.AddGroup(SMSPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SMSPermissions.MyPermission1, L("Permission:MyPermission1"));
        SMSGroup.AddPermission(SMSPermissions.Dashboard.Host, L("Permission:Dashboard"), MultiTenancySides.Host);
        SMSGroup.AddPermission(SMSPermissions.Dashboard.Tenant, L("Permission:Dashboard"), MultiTenancySides.Tenant);

        var booksPermission = SMSGroup.AddPermission(SMSPermissions.Students.Default, L("Permission:Books"));
        booksPermission.AddChild(SMSPermissions.Students.Create, L("Permission:Students.Create"));
        booksPermission.AddChild(SMSPermissions.Students.Edit, L("Permission:Students.Edit"));
        booksPermission.AddChild(SMSPermissions.Students.Delete, L("Permission:Students.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SMSResource>(name);
    }
}
