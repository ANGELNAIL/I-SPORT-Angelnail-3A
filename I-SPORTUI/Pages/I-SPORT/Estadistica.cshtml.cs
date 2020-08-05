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
    public class EstadisticaModel : PageModel
    {
        public readonly IRepository<Jugador> Repository;
        public readonly IRepository<Equipo> eqrepository;
        public readonly IRepository<Estadisticas> estrepository;
        public readonly IRepository<paises> prepository;
        public IEnumerable<Estadisticas> estadisticas2;
        public IEnumerable<Equipo> equipos;
        public IEnumerable<Jugador> jugadores;
        public IEnumerable<paises> paises;
        [BindProperty]
        public Jugador jugador { get; set; }
        [BindProperty]
        public Equipo equpo { get; set; }
        [BindProperty]
        public Estadisticas estadisticas { get; set; }
        [BindProperty]
        public paises pais { get; set; }
        public EstadisticaModel(IRepository<Jugador> repository, IRepository<Equipo> eqrepository, IRepository<Estadisticas> estrepository, IRepository<paises> prepository)
        {
            this.Repository = repository;
            this.eqrepository = eqrepository;
            this.estrepository = estrepository;
            this.prepository = prepository;
        }
        public IActionResult OnGet(int Id)
        {
            jugador = Repository.Get(Id);
            if (jugador.Id == 0)
                return RedirectToPage("/I-SPORT/Ficha_jugador");

            estadisticas2 = estrepository.Get2(Id);
            return Page();
        }
    }
}