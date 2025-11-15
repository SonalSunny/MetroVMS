using MetroVMS.Localization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MetroVMS.Pages
{
    public class HomeModel : PageModel
    {
        private readonly ISharedLocalizer _sharedLocalizer;
        public string LocalizedWelcome { get; private set; }

        public HomeModel(ISharedLocalizer sharedLocalizer)
        {
            _sharedLocalizer = sharedLocalizer;

        }

        public void OnGet()
        {
            //LocalizedWelcome = _sharedLocalizer.Localize("WELCOME").Value;
        }
    }
}
