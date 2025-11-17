using System.ComponentModel.DataAnnotations;

namespace MetroVMS.Entity.BranchMaster.DTO
{
    public class Branch : BaseEntity
    {
        [Key]
        public long BranchId { get; set; }
        public string? BranchName { get; set; }
        public string? BranchCode { get; set; }
        public long? ItemRequestApprover { get; set; }
    }
}
