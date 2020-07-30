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
    public class VerpartidoModel : PageModel
    {
        private readonly IRepository<Partido> repository;
        private readonly IRepository<Equipo> erepository;
        public IEnumerable<Partido> partidos { get; set; }
        public IEnumerable<Equipo> equipos { get; set; }
        public Partido Partidos { get; private set; }

        public VerpartidoModel(IRepository<Partido> repository, IRepository<Equipo> erepository)
        {
            this.repository = repository;
            this.erepository = erepository;
        }
        public IActionResult OnGet(int Id)
        {
            partidos = repository.GetAll();
            equipos = erepository.GetAll();
            return Page();
        }
    }
}