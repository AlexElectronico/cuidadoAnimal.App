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
     Console.WriteLine("Ejercicio insercion de datos ");
     AddPropietario();
    // BuscarPropietario(14);
    }
    
    private static void AddPropietario()
    {
      var propietario=new Propietario()
      {
        // IdPersona=11,
         Nombres="Carlos",
         Apellidos="valderrama",
         Telefono="10101010",
         NombreHacienda=101010101,
         Email="pibe@ffkf",
         Direccion="AV mompelie"
      };  
      _repoPropietario.AddPropietario(propietario);

    } 
    private static void BuscarPropietario(int idcliente)
    {
      var propietario=_repoPropietario.GetPropietario(idcliente);
      Console.WriteLine(propietario.Nombres);

    }

   } 
}
