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


namespace I_SPORTUI.Pages.I_SPORT
{
    public class JugadorModel : PageModel
    {
       
        [BindProperty]
        public Jugador Jugador { get; set; }
        public IFormFile Foto { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }
        private readonly IRepository<Jugador> repository;
        public JugadorModel(IRepository<Jugador> repository, IWebHostEnvironment hostEnvironment)
        {
            this.repository = repository;
            HostEnvironment = hostEnvironment;
        }    
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var id = repository.Insert(Jugador);
            return RedirectToPage("/I-SPORT/Jugador");
        }

        public void OnGet()
        {
        }
    }
}