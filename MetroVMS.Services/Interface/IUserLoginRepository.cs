using MetroVMS.Entity.Identity.ViewModel;
using MetroVMS.Entity;

namespace MetroVMS.Services.Interface
{
    public interface IUserLoginRepository
    {
        Task<ResponseEntity<UserViewModel>> Login(LoginViewModel model);
        Task<bool> Logout();
    }
}
