using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using ReportesColgate.Clases;
using ReportesColgate.Models;
using cm = System.ComponentModel;

namespace ReportesColgate.Controllers
{
    public class DinamicaWalmartController : BaseController
    {
        public static List<DinamicaWalmart> lista;
        //Este metodo nos descarga el excel, word y pdf
        public FileResult Exportar(string[] nombreProp, string tipoReporte)
        {
            if (tipoReporte == "Excel")
            {
                byte[] buffer = ExportarExcelDatos(nombreProp, lista);
                return File(buffer,
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            }
            else if (tipoReporte == "Word")
            {
                byte[] buffer = ExportarWordDatos(nombreProp, lista);
                return File(buffer,
                    "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
            }
            return null;
        }

        public string ExportarDatosPDF(string[] nombreProp)
        {
            byte[] buffer = ExportarPDFDatos(nombreProp, lista);
            string cadena = Convert.ToBase64String(buffer);
            cadena = "data:application/pdf;base64," + cadena;
            return cadena;
        }

        public IActionResult Index()
        {
            List<DinamicaWalmart> listaWalmart = new List<DinamicaWalmart>();
            using(ColgateContext db = new ColgateContext())
            {
                listaWalmart = (from sc in db.Scoredcard
                                where sc.Formato == "WALMART"
                                select new DinamicaWalmart
                                {
                                    Item = sc.Item,
                                    Subcategoria = sc.Subcategoria,
                                    Anio = sc.Anio,
                                    Ac = sc.Ac,
                                    Pais = sc.Pais,
                                    Formato = sc.Formato,
                                    Nomenclatura = sc.Nomenclatura,
                                    Espacio = sc.Espacio,
                                    NumeroTienda = sc.NumeroTienda,
                                    NombreTienda = sc.NombreTienda,
                                    Categoria = sc.Categoria,
                                    Supervisor = sc.Supervisor,
                                    Programa = sc.Programa,
                                    MedicionCms = sc.MedicionCms,
                                    Descripcion = sc.Descripcion,
                                    VndrName = sc.VndrName,
                                    BrandName = sc.BrandName,
                                    CodProv = sc.CodProv,
                                    NomProv = sc.NomProv,
                                    Area = sc.Area,
                                    Upc = sc.Upc,
                                    PorcentajeEspacio = sc.PorcentajeEspacio,
                                    FechaInicioTienda = sc.FechaInicioTienda,
                                    FechaFinTienda = sc.FechaFinTienda,
                                    VendorNbr = sc.VendorNbr,
                                    ApoyoTienda = sc.ApoyoTienda,
                                    CortesCaja = sc.CortesCaja,
                                    ImplementacionModularCudadoOcremasDentales = sc.ImplementacionModularCudadoOcremasDentales,
                                    ImplementacionModularCuidadoOcepillosDentas = sc.ImplementacionModularCuidadoOcepillosDentas,
                                    ImplementacionModularCuidadoOenjaguesBucal = sc.ImplementacionModularCuidadoOenjaguesBucal,
                                    ImplementacionModularCuidadoPjabonesTocad = sc.ImplementacionModularCuidadoPjabonesTocad,
                                    ImplementacionModularCuidadoPdesodorant = sc.ImplementacionModularCuidadoPdesodorant,
                                    ImplementacionModularCuidadoPshamp = sc.ImplementacionModularCuidadoPshamp,
                                    ImplementacionModularCuidadoHsuavisant = sc.ImplementacionModularCuidadoHsuavisant,
                                    ImplementacionModularLavaplat = sc.ImplementacionModularLavaplat,
                                    ImplementacionModularCuidadoHdesinfectant = sc.ImplementacionModularCuidadoHdesinfectant,
                                    Limpieza = sc.Limpieza,
                                    TiendaRotulacionCorrectaRollbacksGp = sc.TiendaRotulacionCorrectaRollbacksGp,
                                    TiendaTieneTodosPreciadoresColocadosAct = sc.TiendaTieneTodosPreciadoresColocadosAct,
                                    CausasCremasDentales = sc.CausasCremasDentales,
                                    FallasCremasDentales = sc.FallasCremasDentales,
                                    CausasCepillosDientes = sc.CausasCepillosDientes,
                                    FallasCepillosDientes = sc.FallasCepillosDientes,
                                    CausasEnjagueBucal = sc.CausasEnjagueBucal,
                                    FallasEnjagueBucal = sc.FallasEnjagueBucal,
                                    CausasJabonesTocador = sc.CausasJabonesTocador,
                                    FallasJabonesTocador = sc.FallasJabonesTocador,
                                    CausasDesodorantes = sc.CausasDesodorantes,
                                    FallasDesodorantes = sc.FallasDesodorantes,
                                    CausasShampoo = sc.CausasShampoo,
                                    FallasShampoo = sc.FallasShampoo,
                                    CausasSuavisantes = sc.CausasSuavisantes,
                                    FallasSuavisantes = sc.FallasSuavisantes,
                                    CausasLavaplatos = sc.CausasLavaplatos,
                                    FallasLavaplatos = sc.FallasLavaplatos,
                                    CausasDesinfectantes = sc.CausasDesinfectantes,
                                    FallasDesinfectantes = sc.FallasDesinfectantes,
                                    CoCkImpulsoCajalineal = sc.CoCkImpulsoCajalineal,
                                    CoCkCpCaJaboncabecera = sc.CoCkCpCaJaboncabecera,
                                    CpCaOral01cabecera = sc.CpCaOral01cabecera,
                                    CpCaOral02cabecera = sc.CpCaOral02cabecera,
                                    CpCaRazuradocabecera = sc.CpCaRazuradocabecera,
                                    CpGbOralgondola = sc.CpGbOralgondola,
                                    DoCaCloroQuitcabecera = sc.DoCaCloroQuitcabecera,
                                    DoCaLabaplatoscabecera = sc.DoCaLabaplatoscabecera,
                                    DoCaLimpiadDesinfectcabecera = sc.DoCaLimpiadDesinfectcabecera,
                                    DoIsCloroisla = sc.DoIsCloroisla,
                                    CpCremaDentEnjuagueacabecera = sc.CpCremaDentEnjuagueacabecera,
                                    CpCremadentEnjuaguealineal = sc.CpCremadentEnjuaguealineal,
                                    CpCremadentEnjuagueBCabecera = sc.CpCremadentEnjuagueBCabecera,
                                    CpJabonLiqCremaDentACabecera = sc.CpJabonLiqCremaDentACabecera,
                                    CpCremaDentEnjuagueBLineal = sc.CpCremaDentEnjuagueBLineal,
                                    CpJabonLiqCremaDentALineal = sc.CpJabonLiqCremaDentALineal,
                                    CpJabonLiqCremaDentBCabecera = sc.CpJabonLiqCremaDentBCabecera,
                                    CpJabonLiqCremaDentBLineal = sc.CpJabonLiqCremaDentBLineal,
                                    DoCloroDesinfectBCabecera = sc.DoCloroDesinfectBCabecera,
                                    DoDetergenteDetLiqBCabecera = sc.DoDetergenteDetLiqBCabecera,
                                    DoCloroDesinfectBCabProd = sc.DoCloroDesinfectBCabProd,
                                    DoDetergenteDetLiqBCabProd = sc.DoDetergenteDetLiqBCabProd,
                                    DoDetergenteDetLiqBLineal = sc.DoDetergenteDetLiqBLineal,
                                    DoIsSuavisanteDetLiqCabecera = sc.DoIsSuavisanteDetLiqCabecera,
                                    DoIsSuavisanteDetLiqLineal = sc.DoIsSuavisanteDetLiqLineal,
                                    DoIsSuavisanteDetLiqIsla = sc.DoIsSuavisanteDetLiqIsla,
                                    DoLimpiadLavaplatosBCabecera = sc.DoLimpiadLavaplatosBCabecera,
                                    DoLimpiadLavaplatosBLineal = sc.DoLimpiadLavaplatosBLineal,
                                    ImpulsosCajasCoRetoEnCajas = sc.ImpulsosCajasCoRetoEnCajas,
                                    CoCkImpulsoCajaProductos = sc.CoCkImpulsoCajaProductos,
                                    CpCaJabonProductos = sc.CpCaJabonProductos,
                                    CpCaOral01Productos = sc.CpCaOral01Productos,
                                    CpCaOral02Productos = sc.CpCaOral02Productos,
                                    CpCaRazuradoProductos = sc.CpCaRazuradoProductos,
                                    CpGbOralProductos = sc.CpGbOralProductos,
                                    DoCaCloroQuitProductos = sc.DoCaCloroQuitProductos,
                                    DoCaLavaplatosProductos = sc.DoCaLavaplatosProductos,
                                    DoCaLimpiadDesinfectProductos = sc.DoCaLimpiadDesinfectProductos,
                                    DoIsCloroProductos = sc.DoIsCloroProductos
                                }).ToList();
            }
            lista = listaWalmart;
            return View(listaWalmart);
        }
    }
}
