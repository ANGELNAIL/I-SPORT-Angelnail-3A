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
    public class EditarpartidoModel : PageModel
    {
        [BindProperty]
        public Partido partido { get; set; }
        public Equipo equipo { get; set; }        
        private readonly IRepository<Partido> repository;
        private readonly IRepository<Equipo> Erepository;
        public IEnumerable<Equipo> Listaequipo { get; set; }
        public EditarpartidoModel(IRepository<Partido> repository, IRepository<Equipo> Erepository)
        {
            this.repository = repository;
            this.Listaequipo = Erepository.GetAll();
        }
        public IActionResult OnPost(Partido partido, string button)
        {
            if (!ModelState.IsValid)
                return Page();
            if (button == "Editar")
            {
                
                repository.Update(partido);
            }
            if (button == "Eliminar")
            {
                repository.Delete(partido);
            }

            return RedirectToPage($"/I-SPORT/Verpartido");
        }
        public IActionResult OnGet(int id)
        {
            partido = repository.Get(id);
            if (partido.Id == 0)
                return RedirectToPage("/I-SPORT/Verpartido");
            return Page();
        }
    }
}