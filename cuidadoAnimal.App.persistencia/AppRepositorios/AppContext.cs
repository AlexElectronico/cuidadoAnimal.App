
using Microsoft.EntityFrameworkCore;
using cuidadoAnimal.App.Dominio;

namespace cuidadoAnimal.App.persistencia

{
    public class AppContext:DbContext
    {
      public DbSet<Animal> Animales {get;set;}  
      public DbSet<Persona> Personas{get;set;}  
      public DbSet<Propietario> Propietarios {get;set;}  
      public DbSet<Veterinario> Veterinarios{get;set;}  
      public DbSet<Visita> Visitas{get;set;} 


       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {

        if(!optionsBuilder.IsConfigured)// configuracion de la base de datos 

        {
        optionsBuilder
        .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=CuidadoAimal");


         }
      }

       
    }

}   