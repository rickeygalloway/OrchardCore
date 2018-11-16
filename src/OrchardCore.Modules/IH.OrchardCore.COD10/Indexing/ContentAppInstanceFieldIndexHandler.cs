using System.Threading.Tasks;
using OrchardCore.ContentFields.Fields;
using IH.OrchardCore.COD10.Fields;
using OrchardCore.Indexing;

namespace IH.OrchardCore.COD10.Indexing
{
    public class ContentAppInstanceFieldIndexHandler : ContentFieldIndexHandler<ContentAppInstanceField>
    {
        public override Task BuildIndexAsync(ContentAppInstanceField field, BuildFieldIndexContext context)
        {
            var options = context.Settings.ToOptions();

            foreach (var key in context.Keys)
            {
                context.DocumentIndex.Set(key, field.Url, options);
                context.DocumentIndex.Set(key, field.Text, options);
            }

            return Task.CompletedTask;
        }
    }
}
