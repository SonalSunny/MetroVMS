using MetroVMS.Localization.Models;
using MetroVMS.Localization.Services;
using Microsoft.AspNetCore.Html;

namespace MetroVMS.Localization
{
    public class SharedLocalizer : ISharedLocalizer
    {
        private readonly ILocalizationService _localizationService;

        public SharedLocalizer(ILocalizationService localizationService)
        {
            _localizationService = localizationService;
        }
        public HtmlString Localize(string resourceKey, params object[] args)
        {
            var currentCulture = Thread.CurrentThread.CurrentUICulture.Name;

            var language = new LocalizationLanguages().Languages.Where(c => c.Culture == currentCulture).FirstOrDefault();
            if (language != null)
            {
                var stringResource = _localizationService.GetStringResource(resourceKey, language.Culture);
                //if (stringResource == null || string.IsNullOrEmpty(stringResource.CustomValue ?? stringResource.Value))
                //{
                //    return new HtmlString(resourceKey);
                //}
                if (stringResource != null && !string.IsNullOrWhiteSpace(stringResource.Value))
                {
                    // Format the string with arguments if any
                    var formattedString = (args == null || args.Length == 0)
                                           ? (!string.IsNullOrEmpty(stringResource.CustomValue)
                                            ? stringResource.CustomValue
                                           : stringResource.Value)
                                            : string.Format(!string.IsNullOrEmpty(stringResource.CustomValue)
                                            ? stringResource.CustomValue
                                            : stringResource.Value, args);
                    //var formattedString = args.Length > 0
                    //    ? string.Format(stringResource.Value, args)
                    //    : stringResource.Value;

                    return new HtmlString(formattedString);
                }
                //return new HtmlString((args == null || args.Length == 0)
                //    ? stringResource.CustomValue ?? stringResource.Value
                //    : string.Format(stringResource.CustomValue ?? stringResource.Value, args));
            }

            return new HtmlString(resourceKey);
        }

        public HtmlString LocalizeMenu(string resourceKey, params object[] args)
        {
            var currentCulture = Thread.CurrentThread.CurrentUICulture.Name;

            var language = new LocalizationLanguages().Languages.Where(c => c.Culture == currentCulture).FirstOrDefault();
            if (language != null)
            {
                var stringResource = _localizationService.GetStringResource(resourceKey, language.Culture);
                if (stringResource == null || string.IsNullOrEmpty(stringResource.CustomValue ?? stringResource.Value))
                {
                    return new HtmlString(resourceKey);
                }

                return new HtmlString((args == null || args.Length == 0)
                    ? stringResource.CustomValue ?? stringResource.Value
                    : string.Format(stringResource.CustomValue ?? stringResource.Value, args));
            }
            return new HtmlString(resourceKey);
        }
    }
}
