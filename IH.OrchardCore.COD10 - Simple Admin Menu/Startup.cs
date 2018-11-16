using OrchardCore.Modules;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Navigation;

namespace IH.OrchardCore.COD10
{
    /// <summary>
    /// These services are registered on the tenant service collection
    /// </summary>
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<INavigationProvider, AdminMenu>();
        }
    }
}
