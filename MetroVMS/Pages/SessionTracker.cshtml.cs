using MetroVMS.Services.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MetroVMS.Pages
{
    public class SessionTrackerModel : PageModel
    {
        private readonly IUserLoginRepository _userLoginRepository;
        public SessionTrackerModel(IUserLoginRepository userLoginRepository)
        {
            _userLoginRepository = userLoginRepository;
        }
        public void OnGet()
        {
        }
        public async Task<JsonResult> OnGetLogOut()
        {
            if (User.Identity.IsAuthenticated)
            {
                await _userLoginRepository.Logout();
            }
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            Response.Cookies.Delete(".AspNetCore.Culture");
            return new JsonResult(true);
        }
    }
}
