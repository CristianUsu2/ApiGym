using System;
using System.ComponentModel.DataAnnotations;

namespace GymApi.Models
{
   public class RutinasUsuario
    {
    [Key]
    public int Id{get;set;}
    public int IdUsuario{get;set;}
    public int IdRutina{get;set;}
    public Boolean Agregado{get;set;} 
    public Rutinas Rutina{get;set;}
    public Usuarios Usuario{get;set;}
  
   }


}