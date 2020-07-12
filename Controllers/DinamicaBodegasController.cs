using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using cm = System.ComponentModel;
using ReportesColgate.Clases;
using ReportesColgate.Models;

namespace ReportesColgate.Controllers
{
    public class DinamicaBodegasController : BaseController
    {
        public static List<DinamicaBodega> lista;

        //Este metodo nos genera el array de bytes(Genera el excel)
        public byte[] ExportarExcelDatos<T>(string[] nombreProp, List<T> lista)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage ep = new ExcelPackage())
                {
                    ep.Workbook.Worksheets.Add("Hoja");

                    ExcelWorksheet ew = ep.Workbook.Worksheets[0];
                    Dictionary<string, string> diccionario = cm.TypeDescriptor
                        .GetProperties(typeof(T))
                        .Cast<cm.PropertyDescriptor>()
                        .ToDictionary(p => p.Name, p => p.DisplayName);

                    for (int i = 0; i < nombreProp.Length; i++)
                    {
                        ew.Cells[1, i + 1].Value = diccionario[nombreProp[i]];
                        ew.Column(i + 1).Width = 50;
                    }
                    int fila = 2;
                    int col = 1;

                    foreach (object item in lista)
                    {
                        col = 1;
                        foreach (string propiedad in nombreProp)
                        {
                            ew.Cells[fila, col].Value =
                                item.GetType().GetProperty(propiedad).GetValue(item).ToString();
                            col++;//Para aumentarle de uno en uno a las filas
                        }
                        fila++;//Para aumentarle de uno en uno a las columnas
                    }
                    //if (nombreProp != null && nombreProp.Length > 0)//Validar checks nulos
                    //{

                    //}
                    ep.SaveAs(ms);
                    byte[] buffer = ms.ToArray();
                    return buffer;
                }
            }
        }

        public IActionResult Index()
        {
            List<DinamicaBodega> listaBodegas = new List<DinamicaBodega>();
            using (ColgateContext db = new ColgateContext())
            {
                listaBodegas = (from sc in db.Scoredcard
                                where sc.Formato == "BODEGAS"
                                select new DinamicaBodega
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
            lista = listaBodegas;
            return View(listaBodegas);
        }
    }
}
