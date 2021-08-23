using System;
using System.ComponentModel.DataAnnotations;

namespace GymApi.Models{

    public class Roles{
     [Key]   
     public int IdRol{get;set;}
     public string Nombre{get;set;}
     public int Estado{get;set;} 
     public Usuarios usuarios{get;set;}
    }
}