using Xunit;

namespace HomerV2.EntityFrameworkCore;

[CollectionDefinition(HomerV2TestConsts.CollectionDefinitionName)]
public class HomerV2EntityFrameworkCoreCollection : ICollectionFixture<HomerV2EntityFrameworkCoreFixture>
{

}
