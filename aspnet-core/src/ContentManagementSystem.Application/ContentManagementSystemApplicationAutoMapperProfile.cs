﻿using AutoMapper;
using ContentManagementSystem.Contents;

namespace ContentManagementSystem;

public class ContentManagementSystemApplicationAutoMapperProfile : Profile
{
    public ContentManagementSystemApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Content, ContentDto>();
        CreateMap<CreateUpdateContentDto, Content>();
    }
}
