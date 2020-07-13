using System;
using System.Collections.Generic;
using System.Text;

namespace I_SPORT.MODEL
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAT { get; set; } = DateTime.Now;
        public DateTime? UpdatedAT { get; set; }
        public bool Status { get; set; } = true;
    }
}
