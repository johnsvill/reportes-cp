using System;
using System.Collections.Generic;

namespace ReportesColgate.Models
{
    public partial class FormatoPrecios
    {
        public int Indice { get; set; }
        public string Tienda { get; set; }
        public string CodigoEmpleado { get; set; }
        public long? Upc { get; set; }
        public long? UpcSinCod { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }
        public string Proveedor { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public string InicioSemana { get; set; }
        public string TerminacionSemana { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
