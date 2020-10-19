using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practica1.Data;
using practica1.Models;


namespace practica1.Controllers
{
    public class formularioController : Controller
    {

       private readonly ILogger<formularioController> _logger;
       private readonly DatabaseContext _context;


        public formularioController(ILogger<formularioController> logger,
            DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ingresar(formulario objFormulario){

                objFormulario.autor="Jair"
                _context.Add(objFormulario);
                _context.SaveChanges();
                
            
        }

    }
}