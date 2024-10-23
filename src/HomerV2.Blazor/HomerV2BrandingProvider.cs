using Microsoft.Extensions.Localization;
using HomerV2.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace HomerV2.Blazor;

[Dependency(ReplaceServices = true)]
public class HomerV2BrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<HomerV2Resource> _localizer;

    public HomerV2BrandingProvider(IStringLocalizer<HomerV2Resource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
