using Platform.Comunication.controller;
using Platform.Object.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario.Navigation
{
    public partial class FormGestionTipoCuenta : Form
    {

        TipoCuentaController tipoCtaControlador = new TipoCuentaController();
        Int32 aux;
        public FormGestionTipoCuenta()
        {
            InitializeComponent();
        }

        private void tBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                String nombre = tBNombre.Text;
                if (nombre.Length != 0)
                {
                    TipoCuenta tipo = tipoCtaControlador.solicitudBuscar(nombre);
                    if (tipo != null)
                    {
                        tBDescripcion.Text = tipo.getDescripcion();
                        aux = tipo.getId();
                        habilitarCampos();
                        btnGuardar.Enabled = false;
                        btnEditar.Enabled = true;
                        btnEliminar.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("El tipo cuenta no existe, por favor adicionalo");
                        habilitarCampos();
                        btnGuardar.Enabled = true;
                        btnEditar.Enabled = false;
                        btnEliminar.Enabled = false;

                    }


                }
            }
        }
        public void habilitarCampos()
        {
            tBDescripcion.ReadOnly = false;
            tBNombre.ReadOnly = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tBDescripcion.Text != "")
            {
                String nombre = tBNombre.Text.ToUpper();
                String descripcion = tBDescripcion.Text;
                String info = tipoCtaControlador.solicitudGuardar(-1, nombre, descripcion);
                MessageBox.Show(info);
                deshabilitarCampos();
                cargarTabla();
                deshabilitarCampos();
            }
            else
                MessageBox.Show("Por favor ingresa la descripción");

        }

        public void deshabilitarCampos()
        {

            tBDescripcion.ReadOnly = true;
            tBNombre.ReadOnly = false;
            limpiarCampos();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        public void limpiarCampos()
        {
            tBNombre.Text = "";
            tBDescripcion.Text = "";

        }

        private void FormGestionTipoCuenta_Load(object sender, EventArgs e)
        {
            cargarTabla();

        }

        public void cargarTabla()
        {
            this.tipo_cuentaTableAdapter.Fill(this.dataSetBanco.tipo_cuenta);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
