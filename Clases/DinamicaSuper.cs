using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReportesColgate.Clases
{
    public class DinamicaSuper
    {
        [Display(Name = "Item")]
        [DisplayName("ITem")]
        public string Item { get; set; }
        [Display(Name = "Sub Categoria")]
        [DisplayName("Sub Categoria")]
        public string Subcategoria { get; set; }
        [Display(Name = "Año")]
        [DisplayName("Año")]
        public string Anio { get; set; }
        [Display(Name = "Actividad Comercial")]
        [DisplayName("Actividad Comercial")]
        public string Ac { get; set; }
        [Display(Name = "Pais")]
        [DisplayName("Pais")]
        public string Pais { get; set; }
        [Display(Name = "Formato de tienda")]
        [DisplayName("Formato de tienda")]
        public string Formato { get; set; }
        [Display(Name = "Nomenclatura")]
        [DisplayName("Nomenclatura")]
        public string Nomenclatura { get; set; }
        [Display(Name = "Espacio")]
        [DisplayName("Espacio")]
        public string Espacio { get; set; }
        [Display(Name = "Número de tienda")]
        [DisplayName("Número de tienda")]
        public string NumeroTienda { get; set; }
        [Display(Name = "Nombre de tienda")]
        [DisplayName("Nombre de tienda")]
        public string NombreTienda { get; set; }
        [Display(Name = "Categoria")]
        [DisplayName("Categoria")]
        public string Categoria { get; set; }
        [Display(Name = "Supervisor")]
        [DisplayName("Supervisor")]
        public string Supervisor { get; set; }
        [Display(Name = "Programa")]
        [DisplayName("Programa")]
        public string Programa { get; set; }
        [Display(Name = "Medición en Cms")]
        [DisplayName("Medición en Cms")]
        public string MedicionCms { get; set; }
        [Display(Name = "Descripción")]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        [Display(Name = "Vendor name")]
        [DisplayName("Vendor name")]
        public string VndrName { get; set; }
        [Display(Name = "Brand name")]
        [DisplayName("Brand name")]
        public string BrandName { get; set; }
        [Display(Name = "Código Prov")]
        [DisplayName("Código Prov")]
        public string CodProv { get; set; }
        [Display(Name = "Nombre Prov")]
        [DisplayName("Nombre Prov")]
        public string NomProv { get; set; }
        [Display(Name = "Area")]
        [DisplayName("Area")]
        public string Area { get; set; }
        [Display(Name = "UPC")]
        [DisplayName("UPC")]
        public string Upc { get; set; }
        [Display(Name = "Porcentaje de espacio")]
        [DisplayName("Porcentaje de espacio")]
        public string PorcentajeEspacio { get; set; }
        [Display(Name = "Fecha inicio en tienda")]
        [DisplayName("Fecha inicio en tienda")]
        public string FechaInicioTienda { get; set; }
        [Display(Name = "Fecha fin en tienda")]
        [DisplayName("Fecha fin en tienda")]
        public string FechaFinTienda { get; set; }
        [Display(Name = "Vendor Nbr")]
        [DisplayName("Vendor Nbr")]
        public string VendorNbr { get; set; }
        [Display(Name = "Apoyo en tienda")]
        [DisplayName("Apoyo en tienda")]
        public string ApoyoTienda { get; set; }
        [Display(Name = "Cortes de caja")]
        [DisplayName("Cortes de caja")]
        public string CortesCaja { get; set; }
        [Display(Name = "Implementación Modular Cudado O. cremas Dentales")]
        [DisplayName("Implementación Modular Cudado O. cremas Dentales")]
        public string ImplementacionModularCudadoOcremasDentales { get; set; }
        [Display(Name = "Implementación Modular Cuidado O. cepillos Dentas")]
        [DisplayName("Implementación Modular Cuidado O. cepillos Dentas")]
        public string ImplementacionModularCuidadoOcepillosDentas { get; set; }
        [Display(Name = "Implementación Modular Cuidado O. enjagues Bucal")]
        [DisplayName("Implementación Modular Cuidado O. enjagues Bucal")]
        public string ImplementacionModularCuidadoOenjaguesBucal { get; set; }
        [Display(Name = "Implementación Modular Cuidado P. jabones Tocad")]
        [DisplayName("Implementación Modular Cuidado P. jabones Tocad")]
        public string ImplementacionModularCuidadoPjabonesTocad { get; set; }
        [Display(Name = "Implementación Modular Cuidado P. desodorant")]
        [DisplayName("Implementación Modular Cuidado P. desodorant")]
        public string ImplementacionModularCuidadoPdesodorant { get; set; }
        [Display(Name = "Implementación Modular Cuidado P. shamp")]
        [DisplayName("Implementación Modular Cuidado P. shamp")]
        public string ImplementacionModularCuidadoPshamp { get; set; }
        [Display(Name = "Implementación Modular Cuidado H. suavisant")]
        [DisplayName("Implementación Modular Cuidado H. suavisant")]
        public string ImplementacionModularCuidadoHsuavisant { get; set; }
        [Display(Name = "Implementación Modular Lavaplat")]
        [DisplayName("Implementación Modular Lavaplat")]
        public string ImplementacionModularLavaplat { get; set; }
        [Display(Name = "Implementación Modular Cuidado H. desinfectant")]
        [DisplayName("Implementación Modular Cuidado H. desinfectant")]
        public string ImplementacionModularCuidadoHdesinfectant { get; set; }
        [Display(Name = "Limpieza")]
        [DisplayName("Limpieza")]
        public string Limpieza { get; set; }
        [Display(Name = "Tienda Rotulación Correcta Rollbacks Gp")]
        [DisplayName("Tienda Rotulación Correcta Rollbacks Gp")]
        public string TiendaRotulacionCorrectaRollbacksGp { get; set; }
        [Display(Name = "Tienda Tiene Todos Preciadores Colocados Act")]
        [DisplayName("Tienda Tiene Todos Preciadores Colocados Act")]
        public string TiendaTieneTodosPreciadoresColocadosAct { get; set; }
        [Display(Name = "Causas Cremas Dentales")]
        [DisplayName("Causas Cremas Dentales")]
        public string CausasCremasDentales { get; set; }
        [Display(Name = "Fallas Cremas Dentales")]
        [DisplayName("Fallas Cremas Dentales")]
        public string FallasCremasDentales { get; set; }
        [Display(Name = "Causas Cepillos Dientes")]
        [DisplayName("Causas Cepillos Dientes")]
        public string CausasCepillosDientes { get; set; }
        [Display(Name = "Fallas Cepillos Dientes")]
        [DisplayName("Fallas Cepillos Dientes")]
        public string FallasCepillosDientes { get; set; }
        [Display(Name = "Causas Enjague Bucal")]
        [DisplayName("Causas Enjague Bucal")]
        public string CausasEnjagueBucal { get; set; }
        [Display(Name = "Fallas Enjague Bucal")]
        [DisplayName("Fallas Enjague Bucal")]
        public string FallasEnjagueBucal { get; set; }
        [Display(Name = "Causas Jabones Tocador")]
        [DisplayName("Causas Jabones Tocador")]
        public string CausasJabonesTocador { get; set; }
        [Display(Name = "Fallas Jabones Tocador")]
        [DisplayName("Fallas Jabones Tocador")]
        public string FallasJabonesTocador { get; set; }
        [Display(Name = "Causas Desodorantes")]
        [DisplayName("Causas Desodorantes")]
        public string CausasDesodorantes { get; set; }
        [Display(Name = "Fallas Desodorantes")]
        [DisplayName("Fallas Desodorantes")]
        public string FallasDesodorantes { get; set; }
        [Display(Name = "Causas Shampoo")]
        [DisplayName("Causas Shampoo")]
        public string CausasShampoo { get; set; }
        [Display(Name = "Fallas Shampoo")]
        [DisplayName("Fallas Shampoo")]
        public string FallasShampoo { get; set; }
        [Display(Name = "Causas Suavisantes")]
        [DisplayName("Causas Suavisantes")]
        public string CausasSuavisantes { get; set; }
        [Display(Name = "Fallas Suavisantes")]
        [DisplayName("Fallas Suavisantes")]
        public string FallasSuavisantes { get; set; }
        [Display(Name = "Causas Lavaplatos")]
        [DisplayName("Causas Lavaplatos")]
        public string CausasLavaplatos { get; set; }
        [Display(Name = "Fallas Lavaplatos")]
        [DisplayName("Fallas Lavaplatos")]
        public string FallasLavaplatos { get; set; }
        [Display(Name = "Causas Desinfectantes")]
        [DisplayName("Causas Desinfectantes")]
        public string CausasDesinfectantes { get; set; }
        [Display(Name = "Fallas Desinfectantes")]
        [DisplayName("Fallas Desinfectantes")]
        public string FallasDesinfectantes { get; set; }
        [Display(Name = "CoCk Impulso Caja lineal")]
        [DisplayName("CoCk Impulso Caja lineal")]
        public string CoCkImpulsoCajalineal { get; set; }
        [Display(Name = "CoCkCpCa Jabon cabecera")]
        [DisplayName("CoCkCpCa Jabon cabecera")]
        public string CoCkCpCaJaboncabecera { get; set; }
        [Display(Name = "CpCa Oral 01cabecera")]
        [DisplayName("CpCa Oral 01cabecera")]
        public string CpCaOral01cabecera { get; set; }
        [Display(Name = "CpCa Oral 02cabecera")]
        [DisplayName("CpCa Oral 02cabecera")]
        public string CpCaOral02cabecera { get; set; }
        [Display(Name = "CpCa Razurado cabecera")]
        [DisplayName("CpCa Razurado cabecera")]
        public string CpCaRazuradocabecera { get; set; }
        [Display(Name = "CpGb Oral gondola")]
        [DisplayName("CpGb Oral gondola")]
        public string CpGbOralgondola { get; set; }
        [Display(Name = "DoCa Cloro Quit cabecera")]
        [DisplayName("DoCa Cloro Quit cabecera")]
        public string DoCaCloroQuitcabecera { get; set; }
        [Display(Name = "DoCa Labaplatos cabecera")]
        [DisplayName("DoCa Labaplatos cabecera")]
        public string DoCaLabaplatoscabecera { get; set; }
        [Display(Name = "DoCa Limpiad Desinfect cabecera")]
        [DisplayName("DoCa Limpiad Desinfect cabecera")]
        public string DoCaLimpiadDesinfectcabecera { get; set; }
        public string DoIsCloroisla { get; set; }
        public string CpCremaDentEnjuagueacabecera { get; set; }
        public string CpCremadentEnjuaguealineal { get; set; }
        public string CpCremadentEnjuagueBCabecera { get; set; }
        public string CpJabonLiqCremaDentACabecera { get; set; }
        public string CpCremaDentEnjuagueBLineal { get; set; }
        public string CpJabonLiqCremaDentALineal { get; set; }
        public string CpJabonLiqCremaDentBCabecera { get; set; }
        public string CpJabonLiqCremaDentBLineal { get; set; }
        public string DoCloroDesinfectBCabecera { get; set; }
        public string DoDetergenteDetLiqBCabecera { get; set; }
        public string DoDetergenteDetLiqBLineal { get; set; }
        public string DoIsSuavisanteDetLiqCabecera { get; set; }
        public string DoIsSuavisanteDetLiqLineal { get; set; }
        public string DoIsSuavisanteDetLiqIsla { get; set; }
        public string DoLimpiadLavaplatosBCabecera { get; set; }
        public string DoLimpiadLavaplatosBLineal { get; set; }
        public string ImpulsosCajasCoRetoEnCajas { get; set; }
        public string CoCkImpulsoCajaProductos { get; set; }
        public string CpCaJabonProductos { get; set; }
        public string CpCaOral01Productos { get; set; }
        public string CpCaOral02Productos { get; set; }
        public string CpCaRazuradoProductos { get; set; }
        public string CpGbOralProductos { get; set; }
        public string DoCaCloroQuitProductos { get; set; }
        public string DoCaLavaplatosProductos { get; set; }
        public string DoCaLimpiadDesinfectProductos { get; set; }
        public string DoIsCloroProductos { get; set; }
        public string CpCremaDentEnjuagueACabProd { get; set; }
        public string CpCremaDentEnjuagueALinProd { get; set; }
        public string CpCremaDentEnjuagueBCabProd { get; set; }
        public string CpJabonLiqCremaDentACabProd { get; set; }
        public string CpJabonLiqCremaDentALinProd { get; set; }
        public string CpJabonLiqCremaDentBCabProd { get; set; }
        public string CpJabonLiqCremaDentBLiqProd { get; set; }
        public string DoCloroDesinfectBCabProd { get; set; }
        public string DoDetergenteDetLiqBCabProd { get; set; }
        public string DoDetergenteDetLiqBLinProd { get; set; }
        public string DoIsSuavizanteDetLiqCabProd { get; set; }
        public string DoIsSuavizanteDetLiqLinProd { get; set; }
        public string DoLimpiadLavaplatosBCabProd { get; set; }
        public string DoLimpiadLavaplatosBLinProd { get; set; }
        public string ImpulsosCajasCoRetoEnCajasProd { get; set; }
        public string CpCremaDentEnjuagueBLinProd { get; set; }
        public string DoIsSuavizanteDetLiqIslaProd { get; set; }
        public string ProductosCHogarDesinfectantes { get; set; }
        public string ProductosCHogarLavaplatos { get; set; }
        public string Gestiones { get; set; }
        public string FaltantesCepillosDeDientes { get; set; }
        public string FaltantesCremasDentales { get; set; }
        public string FaltantesEnjuaguesBucales { get; set; }
        public string FaltantesDesodorantes { get; set; }
        public string FaltantesJabonesDeTocador { get; set; }
        public string FaltantesShampoos { get; set; }
        public string FaltantesSuavisantes { get; set; }
        public string FaltantesLavaplatos { get; set; }
        public string FaltantesDesinfectantes { get; set; }
        public string CantidadIpsGestionadas { get; set; }
        public string CaCp1Cabecera { get; set; }
        public string CaCp1CabeceraProductos { get; set; }
        public string CaHp4Cabecera { get; set; }
        public string CaLr1Cabecera { get; set; }
        public string CaLr1Productos { get; set; }
        public string Isp10IslaPrimaria { get; set; }
        public string Isp10Productos { get; set; }
        public string Isp16IslaPrimaria { get; set; }
        public string Isp16Productos { get; set; }
        public string Iss2IslaSecundaria { get; set; }
        public string Reto01RetoEnCaja { get; set; }
        public string Reto01Productos { get; set; }
        public string TabTab { get; set; }
        public string TabProductos { get; set; }
        public string CaHp4Productos { get; set; }
        public string Iss2Productos { get; set; }
        public string CaLh1Cabecera { get; set; }
        public string CaLh1Productos { get; set; }
        public string CaCo3Cabecera { get; set; }
        public string CaCo3Productos { get; set; }
        public string CaTemp2Cabecera { get; set; }
        public string CaTemp2Productos { get; set; }
        public string CoSkProveedor3Cabecera { get; set; }
        public string CoSkProveedor3Productos { get; set; }
        public string LinealLineal { get; set; }
        public string LinealPrpductos { get; set; }
        public string PlCaCo3Cabecera { get; set; }
        public string PlCaCo3Productos { get; set; }
        public string PlLateral9Lateral { get; set; }
        public string PlLateral9LateralProductos { get; set; }
        public string Reto01RetoEnCajas { get; set; }
        public string Reto01RetoEnCProductos { get; set; }
    }
}
