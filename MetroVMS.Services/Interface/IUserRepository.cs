using MetroVMS.Entity;
using MetroVMS.Entity.Identity.ViewModel;

namespace MetroVMS.Services.Interface
{
    public interface IUserRepository
    {
        Task<ResponseEntity<UserViewModel>> RegisterUser(UserViewModel model);
        ResponseEntity<List<UserViewModel>> GetAllUsers(long? Status, long? Roleid, DateTime? PasswordExpirydateFrom, DateTime? PasswordExpirydateTo);
        ResponseEntity<bool> DeleteUser(UserViewModel objModel);
        ResponseEntity<UserViewModel> GetUserbyId(long userId);
        Task<ResponseEntity<UserViewModel>> UpdateUser(UserViewModel model);
        ResponseEntity<string> ExportUserDatatoExcel(string search, long? statusid, long? Roleid, DateTime? PasswordExpirydateFrom, DateTime? PasswordExpirydateTo);
    }
}
