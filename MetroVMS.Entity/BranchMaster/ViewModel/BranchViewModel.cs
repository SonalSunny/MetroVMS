namespace MetroVMS.Entity.BranchMaster.ViewModel
{
    public class BranchViewModel : BaseEntityViewModel
    {
        public long BranchId { get; set; }
        public string? BranchName { get; set; }
        public string? BranchCode { get; set; }
        public long? ManagerId { get; set; }
    }
}
