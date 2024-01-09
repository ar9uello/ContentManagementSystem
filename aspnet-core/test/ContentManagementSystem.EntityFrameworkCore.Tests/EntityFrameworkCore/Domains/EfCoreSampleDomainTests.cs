using ContentManagementSystem.Samples;
using Xunit;

namespace ContentManagementSystem.EntityFrameworkCore.Domains;

[Collection(ContentManagementSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ContentManagementSystemEntityFrameworkCoreTestModule>
{

}
