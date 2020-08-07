using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using I_SPORT.MODEL;
using I_SPORT.SERVICES;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace I_SPORTUI.Pages.I_SPORT
{
    public class VerestadisticaModel : PageModel
    {
        public readonly IRepository<Jugador> jrepository;
        public readonly IRepository<Estadisticas> Repository;
        public readonly IRepository<Partido> prepository;
        public IEnumerable<Jugador> Jugadores { get; set; }
        public IEnumerable<Estadisticas> Estadisticas { get; set; }
        public IEnumerable<Partido> partidos { get; set; }
        public Jugador jugador { get; private set; }
        public Estadisticas estadisticas { get; private set; }     
        public Partido partido { get; private set; } 
        public VerestadisticaModel(IRepository<Jugador> jrepository, IRepository<Estadisticas> repository, IRepository<Partido> prepository)
        {
            this.Repository = repository;
            this.jrepository = jrepository;
            this.prepository = prepository;
        }       
        public IActionResult OnGet(int Id)
        {
            Estadisticas = Repository.GetAll();
            Jugadores = jrepository.GetAll();
            partidos = prepository.GetAll();
            return Page();
        }
    }
}
