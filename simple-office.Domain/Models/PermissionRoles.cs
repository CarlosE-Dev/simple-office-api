using System.ComponentModel.DataAnnotations.Schema;

namespace simple_office.Domain.Models
{
    [Table("SO_PERMISSION_ROLE")]
    public class PermissionRoles : BaseEntity
    {
        public long PermissionId { get; set; }
        public long RoleId { get; set; }
    }
}
