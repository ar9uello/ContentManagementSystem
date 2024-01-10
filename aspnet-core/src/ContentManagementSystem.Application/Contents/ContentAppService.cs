using System;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ContentManagementSystem.Contents
{
    [RemoteService(false)]
    public class ContentAppService(IRepository<Content, Guid> repository) : 
        CrudAppService<
            Content,
            ContentDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateContentDto>(repository), 
        IContentAppService
    {
    }
}
