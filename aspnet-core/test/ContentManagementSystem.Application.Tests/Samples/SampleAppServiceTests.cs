using ContentManagementSystem.Contents;
using Shouldly;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Xunit;

namespace ContentManagementSystem.Samples;

/* This is just an example test class.
 * Normally, you don't test code of the modules you are using
 * (like IIdentityUserAppService here).
 * Only test your own application services.
 */
public abstract class SampleAppServiceTests<TStartupModule> : ContentManagementSystemApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
    private readonly IIdentityUserAppService _userAppService;
    private readonly IContentAppService _contentAppService;

    protected SampleAppServiceTests()
    {
        _userAppService = GetRequiredService<IIdentityUserAppService>();
        _contentAppService = GetRequiredService<IContentAppService>();
    }

    [Fact]
    public async Task Initial_Data_Should_Contain_Admin_User()
    {
        //Act
        var result = await _userAppService.GetListAsync(new GetIdentityUsersInput());

        //Assert
        result.TotalCount.ShouldBeGreaterThan(0);
        result.Items.ShouldContain(u => u.UserName == "admin");
    }

    [Fact]
    public async Task CreateContent_ShouldSucceed()
    {
        //Act
        var createDto = new CreateUpdateContentDto() { Name = "TestName", HtmlContent = ConvertTextToBytes("TestHtmlContent") };
        var createResult = await _contentAppService.CreateAsync(createDto);

        //Assert
        createResult.ShouldNotBeNull();
    }

    [Fact]
    public async Task UpdateContent_ShouldSucceed()
    {
        //Act
        var createDto = new CreateUpdateContentDto() { Name = "TestName", HtmlContent = ConvertTextToBytes("TestHtmlContent") };
        var createResult = await _contentAppService.CreateAsync(createDto);

        var updateDto = new CreateUpdateContentDto() { Name = "TestNameUpdated", HtmlContent = ConvertTextToBytes("TestHtmlContentUpdated") };
        var updateResult = await _contentAppService.UpdateAsync(createResult.Id, createDto);

        //Assert
        updateResult.Name.Equals("TestNameUpdated");
    }

    [Fact]
    public async Task GetContent_ShouldSucceed()
    {
        //Act
        var createDto = new CreateUpdateContentDto() { Name = "TestName", HtmlContent = ConvertTextToBytes("TestHtmlContent") };
        var createResult = await _contentAppService.CreateAsync(createDto);

        createDto.Guid.ShouldBeNull();
        var getResutl = await _contentAppService.GetAsync(createResult.Id);

        //Assert
        getResutl.Name.Equals("TestName");
    }

    [Fact]
    public async Task GetListContent_ShouldSucceed()
    {
        //Act
        var createDto = new CreateUpdateContentDto() { Name = "TestName", HtmlContent = ConvertTextToBytes("TestHtmlContent") };
        await _contentAppService.CreateAsync(createDto);

        var input = new PagedAndSortedResultRequestDto();
        var getListResult = await _contentAppService.GetListAsync(input);

        //Assert
        getListResult.TotalCount.Equals(1);
    }

    static byte[] ConvertTextToBytes(string text)
    {
        Encoding encoding = Encoding.UTF8;
        return encoding.GetBytes(text);
    }
}
