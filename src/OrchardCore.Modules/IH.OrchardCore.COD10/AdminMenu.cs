using Microsoft.Extensions.Localization;
using OrchardCore.Navigation;
using OrchardCore.Security.Permissions;
using System;
using System.Threading.Tasks;

namespace IH.OrchardCore.COD10
{
    public class AdminMenu : INavigationProvider
    {
        public AdminMenu(IStringLocalizer<AdminMenu> localizer)
        {
            T = localizer;
        }

        public IStringLocalizer T { get; set; }

        public Task BuildNavigationAsync(string name, NavigationBuilder builder)
        {
            if (!String.Equals(name, "admin", StringComparison.OrdinalIgnoreCase))
            {
                return Task.CompletedTask;
            }

            builder.Add(T["COD 10"], "99", content => content
                .AddClass("content-apps").Id("contentapps")
                .LinkToFirstChild(true)
                    .Add(T["Dashboard"], "1", contentTypes => contentTypes
                        .Action("Index", "Admin", new { area = "IH.OrchardCore.COD10" })
                        .Permission(new Permission("ManageContentApps", "Manage Content Apps"))
                        .LocalNav())
                    .Add(T["Settings"], "2", contentTypes => contentTypes
                        .Action("Settings", "Admin", new { area = "IH.OrchardCore.COD10" })
                        .Permission(new Permission("ManageContentApps", "Manage Content Apps"))
                        .LocalNav())
                    );

            return Task.CompletedTask;
        }
    }
}
