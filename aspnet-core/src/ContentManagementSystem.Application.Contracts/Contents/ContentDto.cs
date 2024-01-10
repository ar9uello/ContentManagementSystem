using System;
using Volo.Abp.Application.Dtos;

namespace ContentManagementSystem.Contents;

public class ContentDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }
    public byte[] HtmlContent { get; set; }
}
