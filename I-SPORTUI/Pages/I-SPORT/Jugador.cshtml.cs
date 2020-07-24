﻿using System;
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

namespace I_SPORTUI.Pages.I_SPORT
{
    public class JugadorModel : PageModel
    {


        [BindProperty]
        public Jugador Jugador { get; set; }
        public Equipo equipo { get; set; }
        public IFormFile Foto { get; set; }    
        public IWebHostEnvironment HostEnvironment { get; }
        private readonly IRepository<Jugador> repository;
        private readonly IRepository<Equipo> erepository;
        public IEnumerable<Equipo> Listaequipo { get; set; }
        public JugadorModel(IRepository<Jugador> repository, IRepository<Equipo> erepository, IWebHostEnvironment hostEnvironment)
        {
            this.repository = repository;
            HostEnvironment = hostEnvironment;
            this.Listaequipo = erepository.GetAll();

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var id = repository.Insert(Jugador);
            return RedirectToPage("/I-SPORT/Index");

        }
        public void OnGet()
        {

        }

    }
}