using MetroVMS.Entity.MenuManagement.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroVMS.Entity.Identity.ViewModel
{
    public class RoleAdministrationViewModel
    {
        [BindProperty]
        public string RoleCode { get; set; }
        //public string RoleName { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "REQUIRED")]
        public long? RoleId { get; set; }
        public string RoleName { get; set; }
        public List<MenuGroup> MenuGroups { get; set; }
    }
}
