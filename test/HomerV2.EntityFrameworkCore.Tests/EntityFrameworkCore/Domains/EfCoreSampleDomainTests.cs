using HomerV2.Samples;
using Xunit;

namespace HomerV2.EntityFrameworkCore.Domains;

[Collection(HomerV2TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<HomerV2EntityFrameworkCoreTestModule>
{

}
