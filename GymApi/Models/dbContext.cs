using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using GymApi.Models;
namespace GymApi.Models
{
    public class dbContext:DbContext
    {
      public dbContext(DbContextOptions<dbContext> options):base(options){

      }
      public DbSet<Usuarios> Usuarios{get;set;}
      public DbSet<Roles> Roles{get;set;} 
      public DbSet<FotosRutinas> FotosRutinas{get; set;}
      public DbSet<Mensajes> Mensajes{get;set;}
      public DbSet<MensajesUsuarios> MensajesUsuarios{get;set;}
      public DbSet<Rutinas> Rutinas{get;set;}
      public DbSet<RutinasUsuario> RutinasUsuario{get;set;}
    }
}

