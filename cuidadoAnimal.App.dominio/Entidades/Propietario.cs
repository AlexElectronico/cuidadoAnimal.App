using System;
using System.ComponentModel.DataAnnotations;
namespace cuidadoAnimal.App.dominio
{
    public class Propietario:Persona
    {    
                 
      
        public int NombreHacienda {get; set;}
        
         public string Direccion{get; set;}
         public List<Animal>Animales{get; set;}
                
    }
}