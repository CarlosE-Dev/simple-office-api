using System.ComponentModel.DataAnnotations.Schema;

namespace simple_office.Domain.Models
{
    [Table("SO_USER")]
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public bool IsActiveForEntry { get; set; }
        public bool PasswordReset { get; set; }
        public long RoleId { get; set; }
    }
}
