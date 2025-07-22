using test1.MongoDB;
using test1.Samples;
using Xunit;

namespace test1.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<test1MongoDbTestModule>
{

}
