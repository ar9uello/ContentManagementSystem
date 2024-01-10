using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace ContentManagementSystem.Contents;

public class Content :AuditedAggregateRoot<Guid>
{
    public required string Name { get; set; }
    public required byte[] HtmlContent { get; set; } 
}
