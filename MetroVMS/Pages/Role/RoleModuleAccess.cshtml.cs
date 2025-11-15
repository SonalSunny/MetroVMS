using MetroVMS.Entity.Common;
using MetroVMS.Entity.Identity.ViewModel;
using MetroVMS.Models.PageModels;
using MetroVMS.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MetroVMS.Pages.Role
{
    public class RoleModuleAccessModel : BasePageModel
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IDropDownRepository _dropDownRepository;
        public RoleModuleAccessModel(IMenuRepository menuRepository, IDropDownRepository dropDownRepository)
        {
            _menuRepository = menuRepository;
            _dropDownRepository = dropDownRepository;
        }

        [BindProperty]
        public RoleAdministrationViewModel roleAdministrationModel { get; set; }
        [BindProperty]
        public List<DropDownViewModel> roleGroupList { get; set; }

        public async Task<IActionResult> OnPost()
        {
            var objModel = roleAdministrationModel;
            if (Request.Form["btnSubmit"] == "btnGetRoleInfo")
            {
                ModelState.Clear();
                roleAdministrationModel.RoleCode = "MetroVMS";
                roleAdministrationModel = await _menuRepository.GetPermissionsByRoleIdAsync(roleAdministrationModel?.RoleCode, roleAdministrationModel.RoleId);

            }
            else if (Request.Form["btnSubmit"] == "btnSave")
            {

                var response = await _menuRepository.SaveRoleAdministrations(objModel, (int)objModel.RoleId);
                if (response.transactionStatus != HttpStatusCode.OK)
                {
                    pageErrorMessage = response.returnMessage;
                }
                else
                {
                    ModelState.Clear();
                    IsSuccessReturn = true;
                    sucessMessage = response.returnMessage;
                }

            }
            BindDropdowns();
            return Page();
        }


        public void OnGet()
        {
            BindDropdowns();
        }

        private void BindDropdowns()
        {
            roleGroupList = _dropDownRepository.GetRole();

        }
    }
}
