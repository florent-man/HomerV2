using HomerV2.Samples;
using Xunit;

namespace HomerV2.EntityFrameworkCore.Applications;

[Collection(HomerV2TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<HomerV2EntityFrameworkCoreTestModule>
{

}
