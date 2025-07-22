using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace test1.MongoDB;

[ConnectionStringName(test1DbProperties.ConnectionStringName)]
public class test1MongoDbContext : AbpMongoDbContext, Itest1MongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.Configuretest1();
    }
}
