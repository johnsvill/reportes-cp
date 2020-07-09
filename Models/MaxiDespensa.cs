using System;
using System.Collections.Generic;

namespace ReportesColgate.Models
{
    public partial class MaxiDespensa
    {
        public string Tienda { get; set; }
        public string CodigoEmpleado { get; set; }
        public long Upc { get; set; }
        public long UpcSinCod { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }
        public string Proveedor { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public double InicioSemana { get; set; }
        public double TerminacionSemana { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
