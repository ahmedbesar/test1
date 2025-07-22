using Volo.Abp.Reflection;

namespace test1.Permissions;

public class test1Permissions
{
    public const string GroupName = "test1";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(test1Permissions));
    }
}
