using System.Collections.Generic;  //libreria donde se definen las interfaces
using cuidadoAnimal.App.Dominio;

namespace cuidadoAnimal.App.persistencia
{
    public interface IrepositorioPropietario
    {
        Propietario AddPropietario(Propietario propietario);
        void DeletePropietario(int idpropietario);
        IEnumerable<Propietario> GetAllPropietarios();
        Propietario GetPropietario(int idpropietario);
        Propietario UpdatePropietario(Propietario propietario);
    }

    

}