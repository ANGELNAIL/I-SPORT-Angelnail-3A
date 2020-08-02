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

namespace I_SPORTUI.Pages.I_SPORT
{
    public class EditarequipoModel : PageModel
    {
        [BindProperty]
        public Equipo Equipo { get; set; }
        public IRepository<Equipo> Repository { get; }
        [BindProperty]
        public IFormFile Logo { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }

        public EditarequipoModel(IRepository<Equipo> repository, IWebHostEnvironment hostEnvironment)
        {
            Repository = repository;
            HostEnvironment = hostEnvironment;
        }
        public IActionResult OnPost(Equipo equipo, string button)
        {
            if (!ModelState.IsValid)
                return Page();
            if(button=="Editar")
            {
                if (Logo != null)
                {
                    if (!string.IsNullOrEmpty(equipo.logo))
                    {
                        var filePath = Path.Combine(HostEnvironment.WebRootPath, "images", equipo.logo);
                        System.IO.File.Delete(filePath);
                    }
                    equipo.logo = ProcessUploadFile();
                }
                Repository.Update(equipo);
            }
            if (button == "Eliminar")
            {
                Repository.Delete(equipo);
            }

            return RedirectToPage($"/I-SPORT/Verequipos");

        }

        private string ProcessUploadFile()
        {
            if (Logo == null)
                return string.Empty;

            var uploadFolder = Path.Combine(HostEnvironment.WebRootPath, "images");
            var fileName = $"{Guid.NewGuid()}_{Logo.FileName}";
            var filePath = Path.Combine(uploadFolder, fileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                Logo.CopyTo(stream);
            }
            return fileName;
        }
        public IActionResult OnGet(int id)
        {
            Equipo = Repository.Get(id);
            if (Equipo.Id == 0)
                return RedirectToPage("/I-SPORT/Ficha_jugador");
            return Page();
        }        
    }
}