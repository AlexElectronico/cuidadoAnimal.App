using System;
using System.ComponentModel.DataAnnotations;
namespace   cuidadoAnimal.App.dominio
{
    public class Persona
    {
        [Key]
        public int IdPersona {get; set;}
       // [Requiered,StringLength(50)]
        public string Nombres {get; set;}
       // [Requiered,StringLength(50)]
        public string Apellidos {get; set;}
       // [Requiered,StringLength(50)]
         public string Telefono{get; set;}
        //[Requiered,StringLength(50)]
             
        public string Email{get; set;}
      //  [Requiered,StringLength(50)]
        
      
    }
}