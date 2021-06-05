using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quark_Exam.Modelo
{
    public class Vendedor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int CodigoVendedor { get; set; }
        public HistorialVendedor HistorialVendedor { get; set; }
        public TiendaRopa TiendaDondeTrabaja { get; set; }

        public Vendedor(string nombre, string apellido, int codigo, TiendaRopa tienda) {
            Nombre = nombre;
            Apellido = apellido;
            CodigoVendedor = codigo;
            TiendaDondeTrabaja = tienda;
            HistorialVendedor = new HistorialVendedor(this);
        }

    }
}
