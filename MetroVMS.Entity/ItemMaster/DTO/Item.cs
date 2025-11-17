using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroVMS.Entity.ItemMaster.DTO
{
    public class Item : BaseEntity
    {
        [Key]
        public long ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? ItemCode { get; set; }
        public string? Remark { get; set; }
        public string? UnitOfMeasurement { get; set; }

    }
}
