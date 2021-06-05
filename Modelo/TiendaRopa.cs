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
        }
    }
}
