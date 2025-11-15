using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MetroVMS.Entity.RoleData.DTO;

namespace MetroVMS.Entity.Identity.DTO
{
    public class Users : BaseEntity
    {
        [Key]
        public long UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Culture { get; set; }
        public DateTime? PasswordExpiryDate { get; set; }
        public long? RoleId { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
        public string? ActiveSessionId { get; set; }
        public DateTime? LastLoggedInDatetime { get; set; }

    }
}
