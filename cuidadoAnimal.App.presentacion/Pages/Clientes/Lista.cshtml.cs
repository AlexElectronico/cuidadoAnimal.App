using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using cuidadoAnimal.App.dominio;
using cuidadoAnimal.App.persistencia;
using Microsoft.AspNetCore.Authorization;
//librerias opcionales

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cuidadoAnimal.App.presentacion.Pages
{
    public class ListaModel : PageModel
    {

        private readonly IrepositorioPropietario repositorioPropietario;
        public IEnumerable<Propietario> Propietario{set;get;} 

        public ListaModel()
        {
         this.repositorioPropietario= new RepositorioPropietario(new cuidadoAnimal.App.persistencia.AppContext());  
        }

        public void OnGet(string filtroBusqueda)
        {
            Propietario=repositorioPropietario.GetAllPropietarios();
           
           
         
        }
    }
}
