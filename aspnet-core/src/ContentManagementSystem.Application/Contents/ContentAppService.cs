using System;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Caching;
using Volo.Abp.Domain.Repositories;

namespace ContentManagementSystem.Contents
{
    [RemoteService(false)]
    public class ContentAppService(IRepository<Content, Guid> repository, IDistributedCache<ContentDto> cache) : 
        BaseCrudAppService<
            Content,
            ContentDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateContentDto>(repository, cache), 
        IContentAppService
    {
    }
}
