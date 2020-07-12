using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ReportesColgate.Controllers
{
    public class DinamicasComercialesController : BaseController
    {
        public IActionResult DinamicasComerciales()
        {
            return View();  
        }
    }
}
    