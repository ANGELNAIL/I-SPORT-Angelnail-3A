using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace I_SPORT.MODEL
{
    public class Estadisticas : BaseEntity
    {
        [Display (Name ="Goles")]
        public int Goles { get; set; }
        [Display (Name ="Autogoles")]
        public int Autogoles { get; set; }
        [Display (Name ="Tarjetas rojas")]
        public int TRojas {get; set;}
        [Display(Name = "Tarjetas amarillas")]
        public int TAmarillas { get; set; }
        [Display(Name = "Tarjetas naranjas")]
        public int TNaranas { get; set; }
        [Display(Name = "Tiempo jugado")]
        public int Tjugado { get; set; }
        //Asociaciones
        public int idjugador { get; set; }
        public Jugador jugador { get; set; }

    }
}
