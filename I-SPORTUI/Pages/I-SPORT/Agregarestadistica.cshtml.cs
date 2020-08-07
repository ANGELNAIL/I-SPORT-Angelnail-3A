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
    public class AgregarestadisticaModel : PageModel
    {
        [BindProperty]
        public Jugador jugador { get; set; }
        [BindProperty]
        public Partido partido { get; set; }
        public Estadisticas estadisticas { get; set; }
        public IRepository<Jugador> jrepository;
        public IRepository<Estadisticas> Repository;
        public IRepository<Partido> prepository;
        public IEnumerable<Jugador> Listajugador { get; set; }
        public IEnumerable<Partido> Listapartido { get; set; }
        public AgregarestadisticaModel(IRepository<Jugador> jrepository, IRepository<Estadisticas> repository, IRepository<Partido> prepository)
        {
            Repository = repository;            
            this.Listajugador = jrepository.GetAll();
            this.Listapartido = prepository.GetAll();
        }
        public IActionResult OnPost (Estadisticas estadisticas)
        {
            if (!ModelState.IsValid)
                return Page();
            var id = Repository.Insert(estadisticas);
            return RedirectToPage($"/I-SPORT/Verestadistica");
        }       
    }
}