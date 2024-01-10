using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ContentManagementSystem.Contents;

public interface IContentAppService : 
    ICrudAppService<
        ContentDto, 
        Guid, 
        PagedAndSortedResultRequestDto, 
        CreateUpdateContentDto>
{
}
