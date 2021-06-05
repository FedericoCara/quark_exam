using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quark_Exam.Vista.DTOs
{
    public class DTOCotizacionHistorial
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoPrenda { get; set; }
        public string Calidad { get; set; }
        public int Cantidad { get; set; }
        public float Cotizacion { get; set; }
        public string Detalles { get; set; }

    }
}
