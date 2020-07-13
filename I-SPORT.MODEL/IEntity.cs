using System;
using System.Collections.Generic;
using System.Text;

namespace I_SPORT.MODEL
{
    public interface IEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAT { get; set; }
        public DateTime? UpdatedAT { get; set; }
    }
}
