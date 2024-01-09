using ContentManagementSystem.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ContentManagementSystem.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ContentManagementSystemController : AbpControllerBase
{
    protected ContentManagementSystemController()
    {
        LocalizationResource = typeof(ContentManagementSystemResource);
    }
}
