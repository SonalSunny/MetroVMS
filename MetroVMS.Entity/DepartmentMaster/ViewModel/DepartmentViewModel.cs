using System.ComponentModel.DataAnnotations;

namespace MetroVMS.Entity.DepartmentMaster.ViewModel
{
    public class DepartmentViewModel : BaseEntityViewModel
    {
        public long? DepartmentId { get; set; }
        [Required(ErrorMessage = "REQUIRED")]
        public string? DepartmentName { get; set; }
        public string? Description { get; set; }
        public long? loggedinUserId { get; set; }
    }
}
