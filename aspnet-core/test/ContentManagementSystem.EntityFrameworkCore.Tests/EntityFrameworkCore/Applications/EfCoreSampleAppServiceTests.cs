using ContentManagementSystem.Samples;
using Xunit;

namespace ContentManagementSystem.EntityFrameworkCore.Applications;

[Collection(ContentManagementSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ContentManagementSystemEntityFrameworkCoreTestModule>
{

}
