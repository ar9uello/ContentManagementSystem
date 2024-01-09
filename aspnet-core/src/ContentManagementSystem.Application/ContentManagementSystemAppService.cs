using System;
using System.Collections.Generic;
using System.Text;
using ContentManagementSystem.Localization;
using Volo.Abp.Application.Services;

namespace ContentManagementSystem;

/* Inherit your application services from this class.
 */
public abstract class ContentManagementSystemAppService : ApplicationService
{
    protected ContentManagementSystemAppService()
    {
        LocalizationResource = typeof(ContentManagementSystemResource);
    }
}
