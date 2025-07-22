using test1.Samples;
using Xunit;

namespace test1.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<test1MongoDbTestModule>
{

}
