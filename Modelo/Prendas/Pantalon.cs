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

        public override float CalcularModificadorDePrecio() {
            float modificador = base.CalcularModificadorDePrecio();
            if (TipoPantalon == TipoPantalon.CHUPIN) {
                modificador -= 0.12f;
            }
            return modificador;
        }
    }
}
