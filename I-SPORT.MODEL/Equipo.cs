using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text;

namespace I_SPORT.MODEL
{
    public class Equipo : BaseEntity
    {
        [Display(Name ="Nombre equipo")]
        public string Nombre { get; set; }
    }
}
