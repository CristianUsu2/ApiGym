using System;
using System.ComponentModel.DataAnnotations;

namespace GymApi.Models
{
   public class FotosRutinas{
     [Key]
     public int Id{get;set;}
     public string Foto{get;set;}
     public Rutinas Rutina{get;set;}
   }

}