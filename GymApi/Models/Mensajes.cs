using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GymApi.Models
{
  public class Mensajes{
    [Key]
    public int Id{get;set;} 
    public string Mensaje{get;set;}
    public DateTime fecha{get;set;}
    public ICollection<MensajesUsuarios> Usuario{get;set;}
  }

}