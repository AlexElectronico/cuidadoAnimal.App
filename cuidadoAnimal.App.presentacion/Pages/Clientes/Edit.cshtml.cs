/*
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
    public class EditModel : PageModel
    {
        private readonly IrepositorioPropietario repositorioPropietario;
        [BindProperty]
        public Propietario propietario{set;get;}
        public EditModel()
        {
            this.repositorioPropietario=new RepositorioPropietario(new cuidadoAnimal.App.persistencia.AppContext());
        }

         public IActionResult OnGet(int? idpropietario)
        {
           if (idpropietario.HasValue){
           propietario=repositorioPropietario.GetPropietario(idpropietario.value);
           }
           else{
            propietario=new Propietario(); 
           }
           if(propietario==null){
            return RedirectToPage("./NoFound");
           }
           else{
            return Page();
           }
        }

        public IActionResult OnPost()
        {
          if(!ModelState.IsValid)
          {
            return Page();
          }
          if(propietario.IdPersona>0)
          {
            propietario=repositorioPropietario.UpdatePropietario(propietario);
          }
          else{
            repositorioPropietario.AddPropietario(propietario);
          }
          return Page();

        }
    }
}
*/