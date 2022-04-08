using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Suite1.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View("Clientes");
        }
    }
}
