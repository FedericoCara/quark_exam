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
        public CreadorCotizacionControlador CreadorCotizacionControlador { get; private set; }
        public CreadorVendedorControlador CreadorVendedorControlador { get; set; }

        public CreadorCotizacionForm() {
            InitializeComponent();
            CreadorCotizacionControlador = new CreadorCotizacionControlador();
        }

        public void CompletarPantalla() {
            tiendaNombreLbl.Text = CreadorCotizacionControlador.NombreTienda;
            tiendaDireccionLbl.Text = CreadorCotizacionControlador.DireccionTienda;
            vendedorNombreYApellidoLbl.Text = CreadorCotizacionControlador.NombreYApellidoVendedor;
            vendedorCodigoLbl.Text = CreadorCotizacionControlador.CodigoVendedor;
            camisaRBtn.Checked = true;
            standardRBtn.Checked = true;
            cantidadTxt.Text = "0";
            ActualizarStock();
        }

        private void DesactivarCheckBoxsTipoPrenda() {
            mangaCortaChk.Enabled = false;
            cuelloMaoChk.Enabled = false;
            ChupinChk.Enabled = false;
        }

        private void ActualizarStock() {
            int stock, cantidadParaCotizacion;
            if (camisaRBtn.Checked) {
                stock = CreadorCotizacionControlador.ObtenerStockCamisa(mangaCortaChk.Checked, cuelloMaoChk.Checked);
            } else {
                stock = CreadorCotizacionControlador.ObtenerStockPantalon(ChupinChk.Checked);
            }
            stockLbl.Text = stock.ToString();
            //Actualizar la cantidad para cotizacion si es menor que el stock para la prenda seleccionada
            if (int.TryParse(cantidadTxt.Text, out cantidadParaCotizacion) && cantidadParaCotizacion>stock) {
                cantidadTxt.Text = stock.ToString();
            }
        }

        private void camisaRBtn_CheckedChanged(object sender, EventArgs e) {
            DesactivarCheckBoxsTipoPrenda();
            mangaCortaChk.Enabled = true;
            cuelloMaoChk.Enabled = true;
            ActualizarStock();
        }

        private void pantalonRBtn_CheckedChanged(object sender, EventArgs e) {
            DesactivarCheckBoxsTipoPrenda();
            ChupinChk.Enabled = true;
            ActualizarStock();
        }
        private void mangaCortaChk_CheckedChanged(object sender, EventArgs e) {
            ActualizarStock();
        }

        private void cuelloMaoChk_CheckedChanged(object sender, EventArgs e) {
            ActualizarStock();
        }

        private void ChupinChk_CheckedChanged(object sender, EventArgs e) {
            ActualizarStock();
        }

        private void cotizarBtn_Click(object sender, EventArgs e) {
            float precio;
            int cantidad;
            bool esStandard = standardRBtn.Checked;
            if (!float.TryParse(precioBaseTxt.Text, out precio)) {
                MessageBox.Show("Por favor ingrese un precio válido");
            } else if (!int.TryParse(cantidadTxt.Text, out cantidad)) {
                MessageBox.Show("Por favor ingrese una cantidad válida");
            } else {
                try {
                    cotizacionLbl.Text = CreadorCotizacionControlador.Cotizar(esStandard, precio, cantidad).ToString();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error al cotizar");
                }
            }
        }

        private void CreadorCotizacionForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
