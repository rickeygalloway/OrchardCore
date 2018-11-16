using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Notify;
using IH.OrchardCore.COD10.ViewModels;
using OrchardCore.Environment.Shell;
using OrchardCore.Data;
using Microsoft.AspNetCore.DataProtection;
using OrchardCore.Modules;
using OrchardCore.Recipes.Services;

namespace IH.OrchardCore.COD10.Controllers
{
    public class AdminController : Controller, IUpdateModel
    {
        public AdminController( IShellHost orchardHost,
                                ShellSettings currentShellSettings,
                                IAuthorizationService authorizationService,
                                IShellSettingsManager shellSettingsManager,
                                IEnumerable<DatabaseProvider> databaseProviders,
                                IDataProtectionProvider dataProtectorProvider,
                                IClock clock,
                                INotifier notifier,
                                IEnumerable<IRecipeHarvester> recipeHarvesters,
                                IStringLocalizer<AdminController> stringLocalizer,
                                IHtmlLocalizer<AdminController> htmlLocalizer){ }

        public async Task<IActionResult> Index()
        {
            await Task.CompletedTask;

            var model = new AdminIndexViewModel
            {
                AuthenticationToken = "777C0E26-F231-4C7B-A134-243906EF9442"
            };

            return View();
        }

        public async Task<IActionResult> Settings()
        {
            await Task.CompletedTask;

            return View();
        }

    }
}
