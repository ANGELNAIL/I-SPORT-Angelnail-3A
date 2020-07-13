using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace I_SPORT.MODEL
{
    public class Partido : BaseEntity
    {     
   
        [Display(Name = "Fecha de partido")]
        public DateTime Fechapartido { get; set; }       
     
        //Asociaciones 
        [Display(Name = "Equipo local")]
        public int Equipolocal { get; set; }
        [Display(Name = "Equipo visitante")]
        public int Equipovisitante { get; set; }
        public Equipo equipo { get; set; }

    }
}
