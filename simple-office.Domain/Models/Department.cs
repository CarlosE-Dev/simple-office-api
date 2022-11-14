using System.ComponentModel.DataAnnotations.Schema;

namespace simple_office.Domain.Models
{
    [Table("SO_DEPARTMENT")]
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
    }
}
