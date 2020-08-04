using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace I_SPORT.MODEL
{
     public class Jugador : BaseEntity
    {
        [Display (Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Fecha de naciemto")]
        public DateTime Fechanac { get; set; }
        [Display(Name ="Estatura", Prompt = "Estatura en Metros")]
        public double Estatura { get; set; }       
        [Display(Name = "Posicion")]
        public string posicion { get; set; }
        [Display(Name = "Foto")]
        public string Foto { get; set; }
        //asociaciones
        public int EquipoId { get; set; }          
        public Equipo Equipo { get; set; }

        [Display(Name = "Pais")]
        public int Pais { get; set; }
        public paises paises { get; set; }
    }
}
