using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Web_ll.Models;

namespace Proyecto_Web_ll.Controllers
{
    public class AplicacionController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }

     

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
