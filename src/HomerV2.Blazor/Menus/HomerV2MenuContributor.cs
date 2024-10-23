using System.Threading.Tasks;
using HomerV2.Localization;
using HomerV2.Permissions;
using HomerV2.MultiTenancy;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.UI.Navigation;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.Identity.Pro.Blazor.Navigation;
using Volo.Abp.AuditLogging.Blazor.Menus;
using Volo.Abp.LanguageManagement.Blazor.Menus;
using Volo.Abp.OpenIddict.Pro.Blazor.Menus;
using Volo.Abp.TextTemplateManagement.Blazor.Menus;
using Volo.Saas.Host.Blazor.Navigation;

namespace HomerV2.Blazor.Menus;

public class HomerV2MenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<HomerV2Resource>();
        
        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                HomerV2Menus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home",
                order: 1
            )
        );

        //Administration
        var administration = context.Menu.GetAdministration();
        administration.Order = 4;

        //HostDashboard
        context.Menu.AddItem(
            new ApplicationMenuItem(
                HomerV2Menus.HostDashboard,
                l["Menu:Dashboard"],
                "~/HostDashboard",
                icon: "fa fa-line-chart",
                order: 2
            ).RequirePermissions(HomerV2Permissions.Dashboard.Host)
        );

        context.Menu.Items.Add(
            new ApplicationMenuItem(
                "Applications.Add",
                l["Menu:AddApplication"],
                "/applications/add",
                icon: "fas fa-plus"
            )
        );
        
        //TenantDashboard
        context.Menu.AddItem(
            new ApplicationMenuItem(
                HomerV2Menus.TenantDashboard,
                l["Menu:Dashboard"],
                "~/Dashboard",
                icon: "fa fa-line-chart",
                order: 2
                )
        );
        
        context.Menu.Items.Add(
            new ApplicationMenuItem(
                "Applications.Services",
                l["Menu:Services"],
                "/applications/services",
                icon: "fas fa-cogs"
            )
        );

        context.Menu.Items.Add(
            new ApplicationMenuItem(
                "Applications.Local",
                l["Menu:Local"],
                "/applications/local",
                icon: "fas fa-home"
            )
        );

        context.Menu.Items.Add(
            new ApplicationMenuItem(
                "Applications.Qualif",
                l["Menu:Qualif"],
                "/applications/qualif",
                icon: "fas fa-vial"
            )
        );

        context.Menu.Items.Add(
            new ApplicationMenuItem(
                "Applications.Prod",
                l["Menu:Prod"],
                "/applications/prod",
                icon: "fas fa-industry"
            )
        );

        //Saas
        administration.SetSubItemOrder(SaasHostMenus.GroupName, 1);

        //Administration->Identity
        administration.SetSubItemOrder(IdentityProMenus.GroupName, 2);

        //Administration->OpenIddict
        administration.SetSubItemOrder(OpenIddictProMenus.GroupName, 3);

        //Administration->Language Management
        administration.SetSubItemOrder(LanguageManagementMenus.GroupName, 5);

        //Administration->Text Template Management
        administration.SetSubItemOrder(TextTemplateManagementMenus.GroupName, 6);

        //Administration->Audit Logs
        administration.SetSubItemOrder(AbpAuditLoggingMenus.GroupName, 7);

        //Administration->Settings
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 8);

        return Task.CompletedTask;
    }
}
