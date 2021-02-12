using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioOne.Controllers
{
    public class PortfolioController : Controller {
      // Session Based Methods and variables

      // Routes and middleware
      [HttpGet("")]
      public ViewResult Index()
      {
        return View();
      }
      [HttpGet("projects")]
      public string Projects()
      {
        return "Projects";
      }
      [HttpGet("contact")]
      public string Contact()
      {
        return "Contact Me";
      }
    }
}