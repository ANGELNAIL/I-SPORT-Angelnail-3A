using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using I_SPORT.SERVICES;
using I_SPORT.MODEL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore.Internal;

namespace I_SPORTUI.Pages.I_SPORT
{
    public class AgregarequipoModel : PageModel
    {
        [BindProperty]
        public Equipo Equipo { get; set; }
        public IRepository<Equipo> Repository { get; }
        [BindProperty]
        public IFormFile Logo { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }

        public AgregarequipoModel(IRepository<Equipo> repository, IWebHostEnvironment hostEnvironment)
        {
            Repository = repository;
            HostEnvironment = hostEnvironment;
        }
        public IActionResult OnPost(Equipo equipo)
        {
            if (!ModelState.IsValid)
                return Page();

            if (Logo != null)
            {
                if (!string.IsNullOrEmpty(equipo.logo))
                {
                    var filePath = Path.Combine(HostEnvironment.WebRootPath, "images", equipo.logo);
                    System.IO.File.Delete(filePath);
                }
                equipo.logo = ProcessUploadFile();
            }
            var id = Repository.Insert(equipo);

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

       
    }
}