using Quark_Exam.Modelo;
using Quark_Exam.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quark_Exam.Controladores
{
    public class CreadorVendedorControlador
    {
        public CreadorCotizacionForm CreadorCotizacionForm { get; set; }

        private CreadorVendedorForm creadorVendedorForm;

        public CreadorVendedorControlador(CreadorVendedorForm form) {
            creadorVendedorForm = form;
        }

        public TiendaRopa Tienda { get; set; }

        public void CrearVendedor(string nombre, string apellido, int codigo) {
            Vendedor nuevoVendedor = new Vendedor(nombre, apellido, codigo, Tienda);
            if (CreadorCotizacionForm == null) {
                CreadorCotizacionForm = new CreadorCotizacionForm();
                //En caso de poder crear nuevos vendedores posteriormente, se deja referenciado aquí
                CreadorCotizacionForm.CreadorCotizacionControlador.CreadorVendedorControlador = this;
                CreadorCotizacionForm.CreadorCotizacionControlador.Tienda = Tienda;
            }
            CreadorCotizacionForm.CreadorCotizacionControlador.AddVendedor(nuevoVendedor);
            //Se esconde con el fin de poder luego reutilizar para crear nuevos vendedores (no implementado)
            creadorVendedorForm.Hide();
            CreadorCotizacionForm.CompletarPantalla();
            CreadorCotizacionForm.Show();
        }
    }
}
