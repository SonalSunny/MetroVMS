using System.ComponentModel.DataAnnotations;

namespace MetroVMS.Entity.ItemRequestMasterData.DTO
{
    public class ItemRequestMaster : BaseEntity
    {
        [Key]
        public long RequestId { get; set; }
        public string? RequestNo { get; set; }
        public long? RequestedBy { get; set; }
        public long? DepartmentId { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public bool IsBranchApproved { get; set; }
        public long? BranchApprovedUserID { get; set; }
        public DateTime? BranchApprovedDate { get; set; }
        public bool IsHeadOfficeApproved { get; set; }
        public long? HeadOfficeApprovedUserID { get; set; }
        public DateTime? HeadOfficeApprovedDate { get; set; }
        public long? Status { get; set; }
    }
}
