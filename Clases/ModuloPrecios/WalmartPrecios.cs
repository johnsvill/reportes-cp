using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReportesColgate.Clases.ModuloPrecios
{
    public class WalmartPrecios
    {
        [Display(Name = "Tienda")]
        [DisplayName("Tienda")]
        public string Tienda { get; set; }
        [Display(Name = "Código de empleado")]
        [DisplayName("Código de empleado")]
        public string CodigoEmpleado { get; set; }
        [Display(Name = "UPC")]
        [DisplayName("UPC")]
        public long? Upc { get; set; }
        [Display(Name = "UPC sin código")]
        [DisplayName("UPC sin código")]
        public long? UpcSinCod { get; set; }
        [Display(Name = "Categoria")]
        [DisplayName("Categoria")]
        public string Categoria { get; set; }
        [Display(Name = "Subcategoria")]
        [DisplayName("Subcategoria")]
        public string Subcategoria { get; set; }
        [Display(Name = "Proveedor")]
        [DisplayName("Proveedor")]
        public string Proveedor { get; set; }
        [Display(Name = "Marca")]
        [DisplayName("Marca")]
        public string Marca { get; set; }
        [Display(Name = "Descripción")]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        [Display(Name = "Precio inicio de semana")]
        [DisplayName("Precio inicio de semana")]
        public string InicioSemana { get; set; }
        [Display(Name = "Precio terminación de semana")]
        [DisplayName("Precio terminación de semana")]
        public string TerminacionSemana { get; set; }
        [Display(Name = "Fecha de inicio")]
        [DisplayName("Fecha de inicio")]
        public DateTime FechaInicio { get; set; }
        [Display(Name = "Fecha fin")]
        [DisplayName("Fecha fin")]
        public DateTime FechaFin { get; set; }
    }
}
