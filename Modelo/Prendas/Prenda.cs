using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quark_Exam.Modelo
{
    public abstract class Prenda
    {

        public float CalcularCotizacion(CalidadPrenda calidad, float precio, int cantidad) {
            return (float)Math.Round(cantidad * precio * CalcularModificadorDePrecio(calidad),2);
        }

        public virtual float CalcularModificadorDePrecio(CalidadPrenda calidad) {
            float modificador = 1;
            if (calidad == CalidadPrenda.PREMIUM) {
                modificador += 0.3f;
            }
            return modificador;
        }
    }
}
