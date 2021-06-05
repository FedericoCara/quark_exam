using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quark_Exam.Modelo
{
    public class Cotizacion
    {
        public int NroIdentificacion { get; private set; }
        public Vendedor Vendedor { get; private set; }
        public Prenda Prenda { get; private set; }
        public DateTime FechaYHora { get; private set; }
        public int CantidadPrendas { get; private set; }
        public float PrecioCotizado { get; private set; }

        public Cotizacion(int nroIdentificacion, Vendedor vendedor, Prenda prenda, CalidadPrenda calidad, float precio, int cantidadPrendas) {
            NroIdentificacion = nroIdentificacion;
            Vendedor = vendedor;
            Prenda = prenda;
            FechaYHora = new DateTime();
            CantidadPrendas = cantidadPrendas;
            PrecioCotizado = Prenda.CalcularCotizacion(calidad , precio, CantidadPrendas);
        }

    }
}
