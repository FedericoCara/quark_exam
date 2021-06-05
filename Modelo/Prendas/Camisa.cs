using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quark_Exam.Modelo
{
    public class Camisa : Prenda
    {
        public TipoCuello TipoCuello { get; set; }
        public TipoManga TipoManga { get; set; }

        public Camisa(TipoCuello tipoCuello, TipoManga tipoManga) {
            TipoCuello = tipoCuello;
            TipoManga = tipoManga;
        }

        public override float CalcularModificadorDePrecio(CalidadPrenda calidad) {
            float modificador = base.CalcularModificadorDePrecio(calidad);
            if (TipoManga == TipoManga.MANGA_CORTA) {
                modificador -= 0.1f;
            }
            if (TipoCuello == TipoCuello.MAO) {
                modificador += 0.03f;
            }

            return modificador;
        }
    }
}
