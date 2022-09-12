using System;
using System.ComponentModel.DataAnnotations;//libreria para llave primaria 
namespace   cuidadoAnimal.App.Dominio

{
    public class Animal
    {
        [Key]
        public int IdCerdos {get; set;}
        public string Nombre {get; set;}   
        public string Especie {get; set;} 
        public string Raza {get; set;} 
        public Propietario Propietario{get; set;}


    }
}