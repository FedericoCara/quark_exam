using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quark_Exam.Modelo
{
    public class TiendaRopa
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<DetallePrenda> PrendasEnVenta { get; set; }

        public TiendaRopa(string nombre, string direccion) {
            Nombre = nombre;
            Direccion = direccion;
            PrendasEnVenta = new List<DetallePrenda>();
        }

        public void CargarStock() {
            //Camisas
            PrendasEnVenta.Add(new DetallePrenda(200, new Camisa(TipoCuello.MAO, TipoManga.MANGA_CORTA)));
            PrendasEnVenta.Add(new DetallePrenda(300, new Camisa(TipoCuello.COMUN, TipoManga.MANGA_CORTA)));
            PrendasEnVenta.Add(new DetallePrenda(150, new Camisa(TipoCuello.MAO, TipoManga.MANGA_LARGA)));
            PrendasEnVenta.Add(new DetallePrenda(350, new Camisa(TipoCuello.COMUN, TipoManga.MANGA_LARGA)));

            //Pantalones
            PrendasEnVenta.Add(new DetallePrenda(1500, new Pantalon(TipoPantalon.CHUPIN)));
            PrendasEnVenta.Add(new DetallePrenda(500, new Pantalon(TipoPantalon.COMUN)));
        }
    }
}
