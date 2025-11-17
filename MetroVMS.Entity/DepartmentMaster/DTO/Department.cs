using MetroVMS.Entity;
using System.ComponentModel.DataAnnotations;

namespace MetroVMS.Entity.DepartmentMaster.DTO
{
    public class Department : BaseEntity
    {
        [Key]
        public long DepartmentId { get; set; }
        public long BranchId { get; set; }
        public string? DepartmentName { get; set; }
        public string? Description { get; set; }
    }
}
