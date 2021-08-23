using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GymApi.Models;
namespace GymApi.Controllers
{
  public class GymController:Controller{
    private dbContext DbContext;

    public GymController(dbContext dbContext){
        this.DbContext=dbContext;
    } 
    //[HttpGet] 
    //public IActionResult Index(){
      
    //  return Ok(Rutinas);
    //}

  }

}