using System;
using System.Collections.Generic;
using System.Text;

namespace IH.OrchardCore.COD10.Settings
{
    public class ContentAppInstanceFieldSettings
    {
        public string Hint { get; set; }
        public string HintLinkText { get; set; }
        public bool Required { get; set; }
        public LinkTextMode LinkTextMode { get; set; }
        public string UrlPlaceholder { get; set; }
        public string TextPlaceholder { get; set; }
        public string DefaultUrl { get; set; }
        public string DefaultText { get; set; }

        public ContentAppInstanceFieldSettings()
        {
            LinkTextMode = LinkTextMode.Optional;
        }
    }

    public enum LinkTextMode
    {
        // Some text can be entered or not, if not the url is used
        Optional,
        // Some text must be entered
        Required,
        // Use the default text value defined in the settings
        Static,
        // Use the url
        Url
    }
}
