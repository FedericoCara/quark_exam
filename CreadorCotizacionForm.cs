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
    public partial class CreadorCotizacionForm : Form
    {
        public CreadorCotizacionForm() {
            InitializeComponent();
        }

        public CreadorVendedorControlador CreadorVendedorControlador { get; internal set; }
    }
}
