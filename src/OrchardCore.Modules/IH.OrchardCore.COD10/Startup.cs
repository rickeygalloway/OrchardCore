using OrchardCore.Modules;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Navigation;
using OrchardCore.ContentManagement;
using IH.OrchardCore.COD10.Fields;
using Fluid;
using IH.OrchardCore.COD10.ViewModels;
using OrchardCore.Indexing;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using IH.OrchardCore.COD10.Drivers;
using IH.OrchardCore.COD10.Settings;
using IH.OrchardCore.COD10.Indexing;

namespace IH.OrchardCore.COD10
{
    /// <summary>
    /// These services are registered on the tenant service collection
    /// </summary>
    public class Startup : StartupBase
    {

        static Startup()
        {
            // Registering both field types and shape types are necessary as they can 
            // be accessed from inner properties.
            TemplateContext.GlobalMemberAccessStrategy.Register<ContentAppInstanceField>();
            TemplateContext.GlobalMemberAccessStrategy.Register<DisplayContentAppInstanceFieldViewModel>();

        }

        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<INavigationProvider, AdminMenu>();
                        
            // Instance Field
            services.AddSingleton<ContentField, ContentAppInstanceField>();
            services.AddScoped<IContentFieldDisplayDriver, ContentAppInstanceFieldDisplayDriver>();
            services.AddScoped<IContentPartFieldDefinitionDisplayDriver, ContentAppInstanceFieldSettingsDriver>();
            services.AddScoped<IContentFieldIndexHandler, ContentAppInstanceFieldIndexHandler>();
        }
    }
}
