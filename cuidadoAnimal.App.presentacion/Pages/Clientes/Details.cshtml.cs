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
    public class DetailsModel : PageModel

    {
        private readonly IrepositorioPropietario repositorioPropietario;

        public Propietario propietario{set;get;}
        public DetailsModel()
        {
         this.repositorioPropietario=new RepositorioPropietario(new cuidadoAnimal.App.persistencia.AppContext());
        }
        public IActionResult OnGet(int idpropietario)
        
        {

            propietario=repositorioPropietario.GetPropietario(idpropietario);
            //Console.WriteLine(propietario.Nombres);
                       
         
            if (propietario==null)
            {
                return RedirectToPage("./NoFound");
            }
            else{
               return Page(); 
            }
           




        }
    }
}
