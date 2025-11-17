using MetroVMS.Entity.DepartmentMaster.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroVMS.Entity.EmployeeManagement.DTO
{
    public class Designation : BaseEntity
    {
        [Key]
        public long DesignationId { get; set; }
        public string DesignationRefNumber { get; set; }
        public string? DesignationName { get; set; }
        public string? Description { get; set; }
    }
}
