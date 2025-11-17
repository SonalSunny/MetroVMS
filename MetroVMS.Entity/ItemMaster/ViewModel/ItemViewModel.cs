using System.ComponentModel.DataAnnotations;

namespace MetroVMS.Entity.ItemMaster.ViewModel
{
    public class ItemViewModel : BaseEntityViewModel
    {
        public long ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? ItemCode { get; set; }
        public string? Remark { get; set; }
        public string? UnitOfMeasurement { get; set; }
    }
}
