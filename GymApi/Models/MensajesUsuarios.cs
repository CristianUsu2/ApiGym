using System;
using System.ComponentModel.DataAnnotations;


namespace GymApi.Models
{
   public class MensajesUsuarios{
      [Key]
      public int Id{set;get;}
      public int IdUsuario{set;get;}
      public int IdMensaje{ set; get; }
      public Usuarios Usuario{set;get;}
      public Mensajes Mensaje{set;get;}
   }

}