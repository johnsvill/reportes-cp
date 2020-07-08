using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ReportesColgate.Controllers
{
    public class DinamicasComercialesController : BaseController
    {
        //public FileResult Exportar(string[] nombreProp, string tipoReporte)
        //{
        //    //string[] cabeceras = { "ID de especialidad", "Nombre", "Descripcion" };
        //    //string[] nombreProp = { "IdEspecialidad", "Nombre", "Descripcion" };
        //    if (tipoReporte == "Excel")
        //    {
        //        byte[] buffer = ExportarExcelDatos(nombreProp, lista);
        //        return File(buffer,
        //            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        //    }
        //    else if (tipoReporte == "Word")
        //    {
        //        byte[] buffer = ExportarWordDatos(nombreProp, lista);
        //        return File(buffer,
        //            "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        //    }
        //    return null;
        //}

        //public string ExportarDatosPDF(string[] nombreProp)
        //{
        //    byte[] buffer = ExportarPDFDatos(nombreProp, lista);
        //    string cadena = Convert.ToBase64String(buffer);
        //    cadena = "data:application/pdf;base64," + cadena;
        //    return cadena;
        //}


        public IActionResult DinamicasComerciales()
        {
            return View();  
        }
    }
}
    