using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using I_SPORT.MODEL;
using I_SPORT.SERVICES;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace I_SPORTUI.Pages.I_SPORT
{
    public class EditarjugadorModel : PageModel
    {
        private readonly IRepository<Jugador> repository;
        public Jugador jugador { get; set; }
        public SelectList jugadores { get; set; }       
        public EditarjugadorModel(IRepository <Jugador> repository)
        {
            this.repository = repository;
        }
        public void OnGet(int Id)
        {
            jugador = repository.Get(Id);
            jugadores = new SelectList(repository.Get<Jugador>(), nameof(Jugador.Id), nameof(Jugador.Nombre));
        }
    }
}