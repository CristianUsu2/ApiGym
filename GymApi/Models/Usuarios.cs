using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  GymApi.Models
{
    public class Usuarios{
      [Key]
      public int Id{ get; set;}
      public string Nombre{ get; set;}
      public string Apellido {get;set;}
      public string Telefono {get; set;}
      public string Foto{get; set;}
      public int IdRol{get; set;}
      public int Estado{get;set;}
      public ICollection<Roles> Roles{get; set;} 
      public ICollection<Rutinas> Rutinas{get;set;}
      public ICollection<MensajesUsuarios> Mensajes{get;set;}
    }
}