using ContentManagementSystem.Contents;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace ContentManagementSystem.Controllers;

[Route("api/content")]
public class ContentController(IContentAppService appService) : ContentManagementSystemController
{
    private readonly IContentAppService _appService = appService;

    [HttpPost]
    [Route("InsertOrUpdateCMSContent")]
    public async Task<ContentDto> InsertOrUpdateCMSContent([FromBody]CreateUpdateContentDto input)
    {
        if (input.Guid.HasValue)
            return await _appService.UpdateAsync(input.Guid.Value, input);
        else
            return await _appService.CreateAsync(input);
    }

    [HttpGet]
    [Route("GetCMSContent/{id}")]
    public Task<ContentDto> GetCMSContent(Guid id)
    {
        return _appService.GetAsync(id);
    }

    [HttpGet]
    [Route("GetAll")]
    public Task<PagedResultDto<ContentDto>> GetAll()
    {
        var input = new PagedAndSortedResultRequestDto();
        return _appService.GetListAsync(input);
    }

    [HttpDelete]
    [Route("Remove/{id}")]
    public Task Remove(Guid id)
    {
        return _appService.DeleteAsync(id);
    }
}
