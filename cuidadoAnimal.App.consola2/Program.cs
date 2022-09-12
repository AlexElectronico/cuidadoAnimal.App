using System;
using cuidadoAnimal.App.dominio;
using cuidadoAnimal.App.persistencia;

namespace cuidadoAnimal.App.consola2
{
   class Program

   {
    private static IrepositorioPropietario _repoPropietario=new RepositorioPropietario(new persistencia.AppContext());
    static void Main(string[] args)
    {
     Console.WriteLine("HOLA MUNDO");
     AddPropietario();
    }
    
    private static void AddPropietario()
    {
      var propietario=new Propietario()
      {
        // IdPersona=11,
         Nombres="David",
         Apellidos="ospina",
         Telefono="400404",
         NombreHacienda=3333,
         Email="ospi@ww",
         Direccion="av 456"
      };  
      _repoPropietario.AddPropietario(propietario);

    }


   } 
}
