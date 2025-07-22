using Volo.Abp;
using Volo.Abp.MongoDB;

namespace test1.MongoDB;

public static class test1MongoDbContextExtensions
{
    public static void Configuretest1(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
