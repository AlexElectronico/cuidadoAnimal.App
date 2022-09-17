using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using cuidadoAnimal.App.dominio;
using cuidadoAnimal.App.persistencia;

//librerias opcionales
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cuidadoAnimal.App.presentacion.Pages
{
    public class ingresarModel : PageModel
    {
        private readonly IrepositorioPropietario repositorioPropietario;

        public ingresarModel()
        {
         this.repositorioPropietario=new RepositorioPropietario(new cuidadoAnimal.App.persistencia.AppContext());
        }
        [BindProperty]
        public Propietario Propietario{set;get;}

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
          repositorioPropietario.AddPropietario(Propietario);  
          return RedirectToPage("./Lista");
        }
    }
}
