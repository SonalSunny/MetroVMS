using MetroVMS.Entity;
using MetroVMS.Entity.Identity.ViewModel;
using MetroVMS.Entity.MenuManagement.DTO;
using System.Security.Claims;

namespace MetroVMS.Services.Interface
{
    public interface IMenuRepository
    {
        Task<List<MenuRole>> GetApplicationMenusBygroup(ClaimsPrincipal principal);
        Task<RoleAdministrationViewModel> GetPermissionsByRoleIdAsync(string roleCode, long? roleId);
        Task<ResponseEntity<RoleAdministrationViewModel>> SaveRoleAdministrations(RoleAdministrationViewModel roleAdministration, long roleId);
    }
}
