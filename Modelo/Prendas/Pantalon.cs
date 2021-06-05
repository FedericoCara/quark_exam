using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quark_Exam.Modelo
{
    public class Pantalon : Prenda
    {
        public TipoPantalon TipoPantalon { get; set; }

        public Pantalon(TipoPantalon tipoPantalon) {
            TipoPantalon = tipoPantalon;
        }

        public override float CalcularModificadorDePrecio(CalidadPrenda calidad) {
            float modificador = base.CalcularModificadorDePrecio(calidad);
            if (TipoPantalon == TipoPantalon.CHUPIN) {
                modificador -= 0.12f;
            }
            return modificador;
        }
    }
}
