using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quark_Exam.Controladores;

namespace Quark_Exam
{
    public partial class CreadorTiendaForm : Form
    {

        public CreadorTiendaControlador CreadorTiendaControlador { get; private set; }

        public CreadorTiendaForm() {
            InitializeComponent();
            CreadorTiendaControlador = new CreadorTiendaControlador(this);
        }

        private void crearTiendaBtn_Click(object sender, EventArgs e) {
            string nombre = nombreTxt.Text;
            string direccion = direccionTxt.Text;
            if (string.IsNullOrEmpty(nombre)) {
                MessageBox.Show("Por favor complete el nombre de la tienda");
            } else if (string.IsNullOrEmpty(direccion)) {
                MessageBox.Show("Por favor complete la dirección de la tienda");
            } else {
                CreadorTiendaControlador.CrearTienda(nombre, direccion);
            }
        }
    }
}
