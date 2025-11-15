using Microsoft.AspNetCore.Html;

namespace MetroVMS.Localization
{
    public interface ISharedLocalizer
    {
        public HtmlString Localize(string resourceKey, params object[] args);
        public HtmlString LocalizeMenu(string resourceKey, params object[] args);

    }
}
