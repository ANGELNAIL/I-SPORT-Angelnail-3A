using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using I_SPORT.MODEL;
using I_SPORT.SERVICES;

namespace I_SPORTUI.Pages.I_SPORT
{
    
    public class ReporteModel : PageModel
    {
        public Jugador jugador { get; set; }
        public Estadisticas estadisticas { get; set; }
        public Equipo equipo { get; set; }
        public paises pais { get; set; }

        public void OnGet()
        {

        }
    }
}