using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Caching;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace ContentManagementSystem;

public abstract class BaseCrudAppService<TEntity, TEntityDto, TKey, TGetListInput, TCreateInput>
    : CrudAppService<TEntity, TEntityDto, TKey, TGetListInput, TCreateInput, TCreateInput>
    where TEntity : class, IEntity<TKey>
    where TEntityDto : class, IEntityDto<TKey>
{
    private readonly IDistributedCache<TEntityDto> _cache;

    protected BaseCrudAppService(IRepository<TEntity, TKey> repository, IDistributedCache<TEntityDto> cache)
        : base(repository)
    {
        _cache = cache;
    }

    public override async Task<TEntityDto> GetAsync(TKey id)
    {
        var cacheKey = $"{nameof(TEntity)}_{id}";

        var cachedEntity = await _cache.GetAsync(cacheKey);
        if (cachedEntity != null)
        {
            return cachedEntity;
        }

        var entity = await Repository.GetAsync(id) ?? throw new EntityNotFoundException(typeof(TEntityDto), id);
        var dto = ObjectMapper.Map<TEntity, TEntityDto>(entity);
        await _cache.SetAsync(cacheKey, dto);

        return dto;
    }

    public override async Task DeleteAsync(TKey id)
    {
        _ = await Repository.GetAsync(id) ?? throw new EntityNotFoundException(typeof(TEntityDto), id);
        await base.DeleteAsync(id);
    }

}