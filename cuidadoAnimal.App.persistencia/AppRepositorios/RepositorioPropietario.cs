using System.Collections.Generic;  //libreria donde se definen las interfaces
using cuidadoAnimal.App.dominio;
using System.Linq;

namespace cuidadoAnimal.App.persistencia
{
   public class RepositorioPropietario:IrepositorioPropietario
   {
      private readonly AppContext _appContext;
      public RepositorioPropietario(AppContext appContext)
      {
        _appContext=appContext;
      }


      Propietario IrepositorioPropietario.AddPropietario(Propietario propietario)
      {
         var PropietarioAdicionado=_appContext.Propietarios.Add(propietario);
         _appContext.SaveChanges();
         return PropietarioAdicionado.Entity;
      }


      void  IrepositorioPropietario.DeletePropietario(int idpropietario)
      {
        var PropietarioEncontrado=_appContext.Propietarios.FirstOrDefault(p=>p.IdPersona==idpropietario );
       
        _appContext.Propietarios.Remove(PropietarioEncontrado);
        _appContext.SaveChanges();
      }

      IEnumerable<Propietario> IrepositorioPropietario.GetAllPropietarios()
      {
         return _appContext.Propietarios;  
      }

      Propietario IrepositorioPropietario.GetPropietario(int idpropietario)
      {
       return _appContext.Propietarios.FirstOrDefault(p=>p.IdPersona==idpropietario);

      }

      Propietario IrepositorioPropietario.UpdatePropietario(Propietario propietario)
      {
       var PropietarioEncontrado= _appContext.Propietarios.FirstOrDefault(p=>p.IdPersona==propietario.IdPersona);  
        if(PropietarioEncontrado!=null)
        {
         PropietarioEncontrado.Nombres=propietario.Nombres;
         PropietarioEncontrado.Apellidos=propietario.Apellidos;
         PropietarioEncontrado.Telefono=propietario.Telefono;
         PropietarioEncontrado.Email=propietario.Email;
         PropietarioEncontrado.NombreHacienda=propietario.NombreHacienda;
         PropietarioEncontrado.Direccion=propietario.Direccion;

          _appContext.SaveChanges();

        }

        return PropietarioEncontrado;


      }


      






   }









}