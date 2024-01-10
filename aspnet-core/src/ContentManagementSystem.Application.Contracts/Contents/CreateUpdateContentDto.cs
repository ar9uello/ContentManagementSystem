using System;
using System.ComponentModel.DataAnnotations;

namespace ContentManagementSystem.Contents;

public class CreateUpdateContentDto

{
    public Guid? Guid { get; set; }

    [Required]
    [StringLength(200)]
    public string Name { get; set; }

    [Required]
    public byte[] HtmlContent { get; set; }
}
