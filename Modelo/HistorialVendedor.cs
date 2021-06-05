using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quark_Exam.Modelo
{
    public class HistorialVendedor
    {
        public Vendedor Vendedor { get; private set; }
        private List<Cotizacion> Cotizaciones { get;  set; }

        public HistorialVendedor(Vendedor vendedor) {
            Vendedor = vendedor;
            Cotizaciones = new List<Cotizacion>();
        }

        public void AgregarCotizacion(Cotizacion cotizacion) {
            Cotizaciones.Add(cotizacion);
        }

        public Cotizacion ObtenerCotizacion(int nroCotizacion) {
            return Cotizaciones.Find(cotizacion => cotizacion.NroIdentificacion == nroCotizacion);
        }
    }
}
