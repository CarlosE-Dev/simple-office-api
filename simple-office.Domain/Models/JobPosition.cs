using System.ComponentModel.DataAnnotations.Schema;

namespace simple_office.Domain.Models
{
    [Table("SO_JOB_POSITION")]
    public class JobPosition : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SalaryRange { get; set; }
        public int WorkloadInHours { get; set; }
    }
}
