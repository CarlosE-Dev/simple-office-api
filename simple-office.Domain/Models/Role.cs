using System.ComponentModel.DataAnnotations.Schema;

namespace simple_office.Domain.Models
{
    [Table("SO_ROLE")]
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
