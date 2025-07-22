using test1.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace test1.Permissions;

public class test1PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(test1Permissions.GroupName, L("Permission:test1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<test1Resource>(name);
    }
}
