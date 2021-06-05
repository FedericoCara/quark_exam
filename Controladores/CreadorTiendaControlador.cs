﻿using Quark_Exam.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quark_Exam.Controladores
{
    public class CreadorTiendaControlador
    {
        private CreadorTiendaForm creadorTiendaForm;

        public CreadorTiendaControlador(CreadorTiendaForm form) {
            creadorTiendaForm = form;
        }

        public void CrearTienda(string nombre, string direccion) {
            TiendaRopa nuevaTienda = new TiendaRopa(nombre, direccion);
            //TODO crear stock

            CreadorVendedorForm creadorVendedorForm = new CreadorVendedorForm();
            creadorTiendaForm.Hide(); //TODO Deberia cerrarse sin cerrar el programa
            creadorVendedorForm.CreadorVendedorControlador.Tienda = nuevaTienda;
            creadorVendedorForm.Show();
        }
    }
}
