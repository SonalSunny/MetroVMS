using MetroVMS.Entity;
using MetroVMS.Entity.Identity.ViewModel;
using MetroVMS.Services.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace MetroVMS.Pages
{
    public class LoginModel : PageModel
    {

        private readonly IUserLoginRepository _userLoginRepository;
        private readonly ILogger<LoginModel> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public LoginModel(IUserLoginRepository userLoginRepository, ILogger<LoginModel> logger, IHttpContextAccessor httpContextAccessor)
        {
            _userLoginRepository = userLoginRepository;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }
        [BindProperty]
        public LoginViewModel inputModel { get; set; }
        public string pageErrorMessage { get; set; }

        public void OnGet()
        {
            _logger.LogInformation(1, "NLog injected into HomeController");
        }

        public async Task<JsonResult> OnPost()
        {
            var retData = new ResponseEntity<string>();
            var username = inputModel.Username;
            var password = inputModel.Password;
            if (ModelState.IsValid)
            {
                if (username == null && password == null)
                {   
                    pageErrorMessage = "Login failed.Email and password must not be empty.";
                }
                else
                {
                    var authResponse = await _userLoginRepository.Login(inputModel);
                    if (authResponse.transactionStatus == System.Net.HttpStatusCode.OK)
                    {
                        var claims = new List<Claim>();
                        claims.Add(new Claim("Username", authResponse.returnData.Username ?? ""));
                        claims.Add(new Claim("Culture", authResponse.returnData.Culture ?? "en-US"));
                        claims.Add(new Claim("ThemeMode", authResponse.returnData.ThemeMode ?? "light"));
                        claims.Add(new Claim("EmployeeId", authResponse.returnData.EmployeeID.ToString() ?? ""));
                        claims.Add(new Claim(ClaimTypes.Name, authResponse.returnData.UserId.ToString() ?? ""));
                        claims.Add(new Claim("EmployeeName", authResponse.returnData.EmployeeName ?? ""));
                        claims.Add(new Claim("LoginSessionId", authResponse.returnData.ActiveSessionId ?? ""));
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(claimsIdentity);
                        var authProperties = new AuthenticationProperties
                        {
                            IsPersistent = true // Keep the user logged in across sessions
                        };

                        await _httpContextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                        retData.transactionStatus = System.Net.HttpStatusCode.OK;
                        retData.returnMessage = "OK";
                    }
                    else
                    {
                        pageErrorMessage = authResponse.returnMessage;
                        retData.transactionStatus = authResponse.transactionStatus;
                        retData.returnMessage = authResponse.returnMessage;
                    }
                }
            }
            else
            {
                retData.transactionStatus = System.Net.HttpStatusCode.BadRequest;
                retData.returnMessage = pageErrorMessage;
            }
            return new JsonResult(retData);
        }
    }

}
