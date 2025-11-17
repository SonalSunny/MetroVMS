using MetroVMS.Entity;
using System.ComponentModel.DataAnnotations;

namespace SkakERP.Entity.EmployeeManagement.ViewModel
{
    public class DesignationViewModel : BaseEntityViewModel
    {
        public long? DesignationId { get; set; }
        public string? DesignationRefNo { get; set; }

        [Required(ErrorMessage = "REQUIRED"), MaxLength(20, ErrorMessage = "MAXLENGTH20")]
        public string? DesignationName { get; set; }
        public string? Description { get; set; }

        [Required(ErrorMessage = "REQUIRED")]
        public long? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public long? loggedinUserId { get; set; }
        public bool Active { get; set; }
        public int DiffId { get; set; }
    }
}
