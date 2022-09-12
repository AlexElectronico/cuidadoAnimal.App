using System;
using System.ComponentModel.DataAnnotations;//libreria para llave primaria 
namespace   cuidadoAnimal.App.dominio

{
    public class Visita
    {
        [Key]
        public int IdVisita {get; set;}
        public string fechaVisita {get; set;}   
        public string temperatura {get; set;} 
        public string peso {get; set;} 
         public string recomendaciones{get; set;} 
        public Animal Animal {get; set;}
        public Veterinario Veterinario {get; set;} 


    }
}