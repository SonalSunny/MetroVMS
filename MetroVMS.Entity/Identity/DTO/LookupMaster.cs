using MetroVMS.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroVMS.Entity.Identity.DTO
{
    public class LookupMaster : BaseEntity
    {
        [Key]
        public long LookUpId { get; set; }
        public long LookUpTypeId { get; set; }
        [ForeignKey("LookUpTypeId")]
        public virtual LookUpTypeMaster LookUpTypeMaster { get; set; }
        public string? LookUpName { get; set; }
        public string? Description { get; set; }
    }
}
