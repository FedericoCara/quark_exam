using Quark_Exam.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quark_Exam.Vista.DTOs;

namespace Quark_Exam.Vista
{
    public partial class ConsultaHistorialCotizacionesForm : Form
    {
        public ConsultaHistorialCotizacionesControlador ConsultaHistorialCotizacionesControlador { get; private set; }

        public ConsultaHistorialCotizacionesForm() {
            InitializeComponent();
            ConsultaHistorialCotizacionesControlador = new ConsultaHistorialCotizacionesControlador(this);
        }

        public void ActualizarTabla() {
            List<DTOCotizacionHistorial> cotizaciones = ConsultaHistorialCotizacionesControlador.ObtenerCotizaciones();
            //En lugar de limpiar y rehacer la tabla cada vez que hay un cambio podría crearse un método agregar fila
            //Lo hice de esta forma para simplificar
            historialGridView.Rows.Clear();
            cotizaciones.ForEach(cotizacion => {
                historialGridView.Rows.Add(cotizacion.Numero, cotizacion.Fecha, cotizacion.TipoPrenda,
                                           cotizacion.Calidad, cotizacion.Cantidad, cotizacion.Cotizacion,
                                           cotizacion.Detalles);
            });
        }

        private void ConsultaHistorialCotizacionesForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
