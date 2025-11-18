using MetroVMS.Entity;
using System.ComponentModel.DataAnnotations;

namespace MetroVMS.Entity.Identity.DTO
{
    public class LookUpTypeMaster : BaseEntity
    {
        [Key]
        public long LookUpTypeId { get; set; }
        public string? LookUpTypeName { get; set; }
        public string? Description { get; set; }
    }
}
