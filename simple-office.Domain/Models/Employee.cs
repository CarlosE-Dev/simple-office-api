using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace simple_office.Domain.Models
{
    [Table("SO_EMPLOYEE")]
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public bool RemoteWorking { get; set; }
        public bool IsActiveForEntry { get; set; }
        public long DepartmentId { get; set; }
        public long JobId { get; set; }
    }
}
