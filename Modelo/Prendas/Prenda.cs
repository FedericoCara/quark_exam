using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quark_Exam.Modelo
{
    public abstract class Prenda
    {
        public float Precio { get; set; }
        public CalidadPrenda Calidad { get; set; }

        public float CalcularCotizacion(int cantidad) {
            return cantidad * Precio * CalcularModificadorDePrecio();
        }

        public virtual float CalcularModificadorDePrecio() {
            float modificador = 1;
            if (Calidad == CalidadPrenda.PREMIUM) {
                modificador += 0.3f;
            }
            return modificador;
        }
    }
}
