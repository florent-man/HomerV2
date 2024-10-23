using HomerV2.Localization;
using Volo.Abp.AspNetCore.Components;

namespace HomerV2.Blazor;

public abstract class HomerV2ComponentBase : AbpComponentBase
{
    protected HomerV2ComponentBase()
    {
        LocalizationResource = typeof(HomerV2Resource);
    }
}
