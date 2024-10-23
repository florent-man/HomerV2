using HomerV2.Localization;
using Volo.Abp.Application.Services;

namespace HomerV2;

/* Inherit your application services from this class.
 */
public abstract class HomerV2AppService : ApplicationService
{
    protected HomerV2AppService()
    {
        LocalizationResource = typeof(HomerV2Resource);
    }
}
