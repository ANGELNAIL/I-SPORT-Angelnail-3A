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
    public class Ficha_jugadorModel : PageModel
    {
        
        private readonly IRepository<Jugador> repository;
        private readonly IRepository<Equipo> erepository;
        public IEnumerable<Jugador> jugadores {get; set; }
        public IEnumerable<Equipo> equipos { get; set; }        
        public Jugador jugador { get; private set; }
        public Equipo equipo { get; private set; }
        public Ficha_jugadorModel(IRepository<Jugador> repository, IRepository<Equipo>erepository)
        {
            this.repository = repository;
            this.erepository = erepository;
        }
        public IActionResult OnPost(Jugador jugador)
        {
            if (!ModelState.IsValid)
                return Page();

            repository.Delete(jugador);

            return RedirectToPage($"/I-SPORT/Ficha_jugador");
        }
        public IActionResult OnGet(int Id)
        {
            jugadores = repository.GetAll();
            equipos = erepository.GetAll();
            return Page();
        }       
    }
}