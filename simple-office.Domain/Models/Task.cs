using System.ComponentModel.DataAnnotations.Schema;

namespace simple_office.Domain.Models
{
    [Table("SO_TASK")]
    public class Task : BaseEntity
    {
        public string Description { get; set; }
        public int EstimatedTimeInHours { get; set; }
        public bool Assigned { get; set; }
        public bool Finished { get; set; }
        public long RoleId { get; set; }
    }
}
