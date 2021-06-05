using Quark_Exam.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quark_Exam.Controladores
{
    public class CreadorCotizacionControlador
    {
        public TiendaRopa Tienda { get; set; }

        private List<Vendedor> vendedores = new List<Vendedor>();
        private int vendedorSeleccionadoIndice = 0;
        public Vendedor VendedorSeleccionado => vendedores[vendedorSeleccionadoIndice];

        public string NombreTienda => Tienda.Nombre;
        public string DireccionTienda => Tienda.Direccion;
        public string NombreYApellidoVendedor => $"{VendedorSeleccionado.Nombre} {VendedorSeleccionado.Apellido}";
        public string CodigoVendedor => VendedorSeleccionado.CodigoVendedor.ToString();

        public int CodigoUltimaCotizacion { get; private set; }
        public DetallePrenda UltimaPrendaSeleccionada { get; private set; }


        public void AddVendedor(Vendedor nuevoVendedor) {
            vendedores.Add(nuevoVendedor);
            vendedorSeleccionadoIndice = vendedores.Count - 1;
        }

        public int ObtenerStockCamisa(bool esMangaCorta, bool esCuelloMao) {
            DetallePrenda detallePrendaEncontrado = Tienda.PrendasEnVenta.Find(detallePrenda => {
                if (detallePrenda.Prenda is Camisa) {
                    Camisa camisa = (Camisa)detallePrenda.Prenda;
                    return esMangaCorta == (camisa.TipoManga == TipoManga.MANGA_CORTA) &&
                           esCuelloMao == (camisa.TipoCuello == TipoCuello.MAO);
                } else {
                    return false;
                }
            });
            if (detallePrendaEncontrado != null) {
                UltimaPrendaSeleccionada = detallePrendaEncontrado;
                return detallePrendaEncontrado.Cantidad;
            } else {
                return 0;
            }
        }

        public int ObtenerStockPantalon(bool esChupin) {
            DetallePrenda detallePrendaEncontrado = Tienda.PrendasEnVenta.Find(detallePrenda => {
                if (detallePrenda.Prenda is Pantalon) {
                    Pantalon pantalon = (Pantalon)detallePrenda.Prenda;
                    return esChupin == (pantalon.TipoPantalon == TipoPantalon.CHUPIN);
                } else {
                    return false;
                }
            });
            if (detallePrendaEncontrado != null) {
                UltimaPrendaSeleccionada = detallePrendaEncontrado;
                return detallePrendaEncontrado.Cantidad;
            } else {
                return 0;
            }
        }

        public float Cotizar(bool esStandard, float precio, int cantidad) {
            CalidadPrenda calidad = esStandard ? CalidadPrenda.STANDARD : CalidadPrenda.PREMIUM;
            if (UltimaPrendaSeleccionada != null && UltimaPrendaSeleccionada.Cantidad >= cantidad) {
                Cotizacion nuevaCotizacion = new Cotizacion(++CodigoUltimaCotizacion, VendedorSeleccionado,
                                                            UltimaPrendaSeleccionada.Prenda,
                                                            calidad, precio, cantidad);
                VendedorSeleccionado.AgregarCotizacion(nuevaCotizacion);
                return nuevaCotizacion.PrecioCotizado;
            } else {
                throw new Exception("No hay suficiente Stock para realizar la cotización");
            }
        }
    }
}
