using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using I_SPORT.MODEL;
using I_SPORT.SERVICES;
using Microsoft.AspNetCore.Hosting;

namespace I_SPORTUI.Pages.I_SPORT
{
    public class AgregarPartidoModel : PageModel
    {
        [BindProperty]
        public Partido partido { get; set; }    
        public Equipo equipo { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }
        private readonly IRepository<Partido> repository;
        private readonly IRepository<Equipo> Erepository;
        public IEnumerable<Equipo> Listaequipo { get; set; }
        public AgregarPartidoModel(IRepository<Partido> repository, IRepository<Equipo> Erepository, IWebHostEnvironment hostEnvironment)
        {
            this.repository = repository;
            HostEnvironment = hostEnvironment;
            this.Listaequipo = Erepository.GetAll();

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var id = repository.Insert(partido);         
            return RedirectToPage("/I-SPORT/Index");

        }
        public void OnGet()
        {

        }

    }
}
