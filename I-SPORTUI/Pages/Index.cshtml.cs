using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using I_SPORT.MODEL;
using I_SPORT.SERVICES;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace I_SPORTUI.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public User user { get; set; }       
        public IWebHostEnvironment HostEnvironment { get; }
        private readonly IRepository<User> repository;
        public IndexModel(IRepository<User> repository, IWebHostEnvironment hostEnvironment)
        {
            this.repository = repository;
            HostEnvironment = hostEnvironment;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page( );

            var id = repository.Insert(user);
            return RedirectToPage("/I-SPORT/Index");
        }
        public void OnGet()
        {

        }
       
    }
}
