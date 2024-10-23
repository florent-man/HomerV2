using HomerV2.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HomerV2.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HomerV2Controller : AbpControllerBase
{
    protected HomerV2Controller()
    {
        LocalizationResource = typeof(HomerV2Resource);
    }
}
