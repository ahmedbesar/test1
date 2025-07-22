using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace test1.MongoDB;

[ConnectionStringName(test1DbProperties.ConnectionStringName)]
public interface Itest1MongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
