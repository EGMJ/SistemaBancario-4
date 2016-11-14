using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Platform.Comunication.controller;
using Platform.Object.model;
namespace SistemaBancario.Navigation
{
    public partial class FormGestionPais : Form
    {

        PaisController ctlPais;
        int aux;

        public FormGestionPais()
        {
            InitializeComponent();
            ctlPais = new PaisController();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String descr = txtDescripcion.Text;
            if (nombre == "")
            {
                MessageBox.Show("Escriba el nombre");
            }
            else
            {
                if (ctlPais.SolicitudGuardarPais(nombre, descr))
                {
                    MessageBox.Show("Exito al registrar");
                    deshabilitarCampos();
                    cargarTabla();
                }
                else
                {
                    MessageBox.Show("Error..");
                }
            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String descr = txtDescripcion.Text;
            if (nombre == "")
            {
                MessageBox.Show("Escriba el nombre");
            }
            else
            {
                if (ctlPais.SolicitudModificarPais(nombre, descr))
                {
                    MessageBox.Show("Exito al modificar");
                    deshabilitarCampos();
                    cargarTabla();
                    aux = 0;
                }
                else
                {
                    MessageBox.Show("Error..");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            if (nombre == "")
            {
                MessageBox.Show("Escriba el nombre");
            }
            else
            {
                if (ctlPais.solicitudEliminarPais(nombre))
                {
                    MessageBox.Show("Eliminado con exito");
                    deshabilitarCampos();
                    aux = 0;
                    cargarTabla();

                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                String nombre = txtNombre.Text;
                if (nombre.Length != 0)
                {
                    Pais p = ctlPais.SolicitudBuscarPais(nombre);
                    if (p != null)
                    {
                        txtDescripcion.Text = p.getDescripcion();
                        aux = p.getId();
                        habilitarCampos();
                        btnGuardar.Enabled = false;
                        btnEditar.Enabled = true;
                        btnEliminar.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("El país no existe, por favor adicionalo");
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
            txtDescripcion.ReadOnly = false;
            txtNombre.ReadOnly = true;
        }

        public void deshabilitarCampos()
        {

            txtDescripcion.ReadOnly = true;
            txtNombre.ReadOnly = false;
            limpiar();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void FormGestionPais_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.pais' Puede moverla o quitarla según sea necesario.

            cargarTabla();
        }
        public void cargarTabla()
        {
            this.paisTableAdapter.Fill(this.dataSetBanco.pais);
        }
    }
}
