using System;

namespace simple_office.Domain.Models
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedOn = DateTime.Now;
        }

        public long Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
