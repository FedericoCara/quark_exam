using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quark_Exam.Modelo;
using Quark_Exam.Vista;
using Quark_Exam.Vista.DTOs;
using static Quark_Exam.Modelo.HistorialVendedor;

namespace Quark_Exam.Controladores
{
    public class ConsultaHistorialCotizacionesControlador
    {
        private ConsultaHistorialCotizacionesForm consultaHistorialCotizacionesForm;

        private HistorialVendedor historialVendedor;
        public HistorialVendedor HistorialVendedor {
            get => historialVendedor;
            set {
                historialVendedor = value;
                historialVendedor.Listeners += consultaHistorialCotizacionesForm.ActualizarTabla;
            }
        }

        private List<DTOCotizacionHistorial> cotizaciones = new List<DTOCotizacionHistorial>();

        public ConsultaHistorialCotizacionesControlador(ConsultaHistorialCotizacionesForm consultaHistorialCotizacionesForm) {
            this.consultaHistorialCotizacionesForm = consultaHistorialCotizacionesForm;
        }

        public List<DTOCotizacionHistorial> ObtenerCotizaciones() {
            cotizaciones.Clear();
            HistorialVendedor.Cotizaciones.ForEach(cotizacion => {
                DTOCotizacionHistorial dto = new DTOCotizacionHistorial() {
                    Numero = cotizacion.NroIdentificacion,
                    Fecha = cotizacion.FechaYHora,
                    Cantidad = cotizacion.CantidadPrendas,
                    Cotizacion = cotizacion.PrecioCotizado
                };
                if (cotizacion.Prenda is Camisa) {
                    Camisa camisa = (Camisa)cotizacion.Prenda;
                    dto.TipoPrenda = "Camisa";
                    dto.Detalles = $"{camisa.TipoCuello}, {camisa.TipoManga}";
                } else if(cotizacion.Prenda is Pantalon) {
                    Pantalon pantalon = (Pantalon)cotizacion.Prenda;
                    dto.TipoPrenda = "Pantalón";
                    dto.Detalles = $"{pantalon.TipoPantalon}";
                }
                switch (cotizacion.CalidadPrenda) {
                    case CalidadPrenda.STANDARD:
                        dto.Calidad = "Standard";
                        break;
                    case CalidadPrenda.PREMIUM:
                        dto.Calidad = "Premium";
                        break;
                }
                cotizaciones.Add(dto);
            });
            return cotizaciones;
        }
    }
}
