using System;
using System.ComponentModel.DataAnnotations;
namespace   cuidadoAnimal.App.Dominio
{
    public class Propietario:Persona
    {    
                 
      
        public int NombreHacienda {get; set;}
         public string Direccion{get; set;}
                
    }
}