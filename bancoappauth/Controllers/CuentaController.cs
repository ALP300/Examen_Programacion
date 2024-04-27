using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bancoappauth.Models;


namespace bancoappauth.Controllers
{
    public class CuentaController : Controller
    {
         private readonly ILogger<CuentaController> _logger;

        public CuentaController(ILogger<CuentaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
    
        public IActionResult Create([Bind("Id,Nombre,TipoC,SaldoI,Email")] Cuentas cuenta)
        {
            if (ModelState.IsValid)
            {
          ViewData["Message"] = "¡Cuenta registrada!";
              return View("Index");
            }
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }


    }
}