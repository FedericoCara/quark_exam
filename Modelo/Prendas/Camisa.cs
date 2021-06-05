using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quark_Exam.Modelo
{
    public class Camisa : Prenda
    {
        public bool EsCuelloMao { get; set; }
        public TipoManga TipoManga { get; set; }

        public override float CalcularModificadorDePrecio() {
            float modificador = base.CalcularModificadorDePrecio();
            if (TipoManga == TipoManga.MANGA_CORTA) {
                modificador -= 0.1f;
            }
            if (EsCuelloMao) {
                modificador += 0.03f;
            }

            return modificador;
        }
    }
}
