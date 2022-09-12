using System;
using System.ComponentModel.DataAnnotations;
namespace   cuidadoAnimal.App.dominio
{
    public class Persona
    {
        [Key]
        public int IdPersona {get; set;}
        public string Nombres {get; set;}
        public string Apellidos {get; set;}
         public string Telefono{get; set;}
       
       
        public string Email{get; set;}
        
      
    }
}