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

namespace Quark_Exam
{
    public partial class CreadorVendedorForm : Form
    {
        public CreadorVendedorControlador CreadorVendedorControlador { get; private set; }

        public CreadorVendedorForm() {
            InitializeComponent();
            CreadorVendedorControlador = new CreadorVendedorControlador(this);
        }

        private void crearVendedorBtn_Click(object sender, EventArgs e) {
            string nombre = nombreTxt.Text;
            string apellido = apellidoTxt.Text;
            int codigo;

            if (string.IsNullOrEmpty(nombre)) {
                MessageBox.Show("Por favor complete el nombre del vendedor");
            } else if (string.IsNullOrEmpty(apellido)) {
                MessageBox.Show("Por favor complete el apellido del vendedor");
            } else if (!int.TryParse(codigoTxt.Text, out codigo)) {
                MessageBox.Show("Por favor complete el código del vendedor con un número");
            } else {
                CreadorVendedorControlador.CrearVendedor(nombre, apellido, codigo);
            }
        }
    }
}
