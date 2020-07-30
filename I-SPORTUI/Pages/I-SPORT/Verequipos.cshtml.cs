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
    public class VerequiposModel : PageModel
    {
        private readonly IRepository<Equipo> repository;
        public IEnumerable<Equipo> equipos { get; set; }
        public Equipo equipo { get; private set; }

        public VerequiposModel(IRepository<Equipo> repository)
        {
            this.repository=repository;
        }
        public void OnGet(int Id)
        {
            equipos = repository.GetAll();
        }


    }
}