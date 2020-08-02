using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using I_SPORT.MODEL;
using I_SPORT.SERVICES;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace I_SPORTUI.Pages.I_SPORT
{
    public class EditarjugadorModel : PageModel
    {
        private readonly IRepository<Jugador> repository;       
        [BindProperty]
        public Jugador jugador { get; set; }
        [BindProperty]
        public Equipo equipo { get; set; }
        [BindProperty]
        public IFormFile Foto { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }        
        private readonly IRepository<Equipo> erepository;
        public IEnumerable<Equipo> Listaequipo { get; set; }
        public EditarjugadorModel(IRepository <Jugador> repository, IRepository<Equipo> erepository, IWebHostEnvironment hostEnvironment)
        {
            this.repository = repository;
            HostEnvironment = hostEnvironment;
            this.Listaequipo = erepository.GetAll();
        }
        public IActionResult OnGet(int id)
        {
            jugador = repository.Get(id);
            if (jugador.Id == 0)
                return RedirectToPage("/I-SPORT/Ficha_jugador");
            return Page();
        }
        public IActionResult OnPost(Jugador jugador, string button)
        {            
            if (!ModelState.IsValid)
                return Page();

            if (button== "Editar")
            {
                if (Foto != null)
                {
                    if (!string.IsNullOrEmpty(jugador.Foto))
                    {
                        var filePath = Path.Combine(HostEnvironment.WebRootPath, "images", jugador.Foto);
                        System.IO.File.Delete(filePath);
                    }
                    jugador.Foto = ProcessUploadFile();
                }
                repository.Update(jugador);
            }
            if (button == "Eliminar")
            {
                repository.Delete(jugador);
            }

            return RedirectToPage($"/I-SPORT/Ficha_jugador");
        }       
        private string ProcessUploadFile()
        {
            if (Foto == null)
                return string.Empty;

            var uploadFolder = Path.Combine(HostEnvironment.WebRootPath, "images");
            var fileName = $"{Guid.NewGuid()}_{Foto.FileName}";
            var filePath = Path.Combine(uploadFolder, fileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                Foto.CopyTo(stream);
            }
            return fileName;
        }       
    }
}