using System;
using System.ComponentModel.DataAnnotations;
using GymApi.Models;
using System.Collections.Generic;
namespace GymApi.Models
{
  public class Rutinas{
   [Key]   
   public int IdRutina{set;get;}
   public string NombreRutina{set;get;}
   public string Descripcion {set;get;} 
   public string Foto{set; get;}
   public int Estado{set;get;}
   public string Video{set;get;}
   public ICollection<Usuarios> Usuarios{get;set;}
   public ICollection<FotosRutinas> FotosRutinas{get;set;}
    
  }


}
