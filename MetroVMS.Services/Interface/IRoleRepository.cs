using MetroVMS.Entity;
using MetroVMS.Entity.Identity.ViewModel;

namespace MetroVMS.Services.Interface
{
    public interface IRoleRepository
    {

        Task<ResponseEntity<RoleViewModel>> SaveRole(RoleViewModel model);
        Task<ResponseEntity<RoleViewModel>> UpdateRole(RoleViewModel model);
        ResponseEntity<bool> DeleteRole(RoleViewModel objModel);
        public ResponseEntity<List<RoleViewModel>> GetAllRole(long? Status, string firstName);
        ResponseEntity<RoleViewModel> GetRolebyId(long userId);
        ResponseEntity<string> ExportRoleDatatoExcel(long? Status, string search);
    }
}
