using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using I_SPORT.SERVICES;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using I_SPORT.MODEL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace I_SPORTUI.Pages.I_SPORT
{
    public class JugadorModel : PageModel
    {


        [BindProperty]
        public Jugador Jugador { get; set; }
        public Equipo equipo { get; set; }
        public paises pais { get; set; }
        [BindProperty]
        public IFormFile Foto { get; set; }    
        public IWebHostEnvironment HostEnvironment { get; }
        private readonly IRepository<Jugador> repository;
        private readonly IRepository<Equipo> erepository;
        private readonly IRepository<paises> prepository;
        public IEnumerable<Equipo> Listaequipo { get; set; }
        public IEnumerable<paises> Listapaises { get; set; }
        public JugadorModel(IRepository<Jugador> repository, IRepository<Equipo> erepository, IRepository<paises> prepository, IWebHostEnvironment hostEnvironment)
        {
            this.repository = repository;
            HostEnvironment = hostEnvironment;
            this.Listaequipo = erepository.GetAll();
            this.Listapaises = prepository.GetAll();
        }
        public IActionResult OnPost(Equipo equipo)
        {
            if (!ModelState.IsValid)
                return Page();

            if (Foto != null)
            {
                if (!string.IsNullOrEmpty(Jugador.Foto))
                {
                    var filePath = Path.Combine(HostEnvironment.WebRootPath, "images", Jugador.Foto);
                    System.IO.File.Delete(filePath);
                }
                Jugador.Foto = ProcessUploadFile();
            }
            var id = repository.Insert(Jugador);

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