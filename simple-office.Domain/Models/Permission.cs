using System.ComponentModel.DataAnnotations.Schema;

namespace simple_office.Domain.Models
{
    [Table("SO_PERMISSION")]
    public class Permission : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActiveForEntry { get; set; }
    }
}
