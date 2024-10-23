using Volo.Abp.Settings;

namespace HomerV2.Settings;

public class HomerV2SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(HomerV2Settings.MySetting1));
    }
}
