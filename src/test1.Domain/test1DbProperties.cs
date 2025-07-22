namespace test1;

public static class test1DbProperties
{
    public static string DbTablePrefix { get; set; } = "test1";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "test1";
}
