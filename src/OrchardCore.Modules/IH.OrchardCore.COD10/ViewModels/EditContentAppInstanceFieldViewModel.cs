using IH.OrchardCore.COD10.Fields;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata.Models;

namespace IH.OrchardCore.COD10.ViewModels
{
    public class EditContentAppInstanceFieldViewModel
    {
        public string Url { get; set; }
        public string Text { get; set; }
        public ContentAppInstanceField Field { get; set; }
        public ContentPart Part { get; set; }
        public ContentPartFieldDefinition PartFieldDefinition { get; set; }
    }
}
