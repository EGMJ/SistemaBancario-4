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
    public partial class FormGestionDepartamento : Form
    {

        DepartamentoController ctlDepto;
        int aux;
        public FormGestionDepartamento()
        {
            InitializeComponent();
            ctlDepto = new DepartamentoController();
        }

        private void FormGestionDepartamento_Load(object sender, EventArgs e)
        {
            cargarPais();
            cargarTabla();

        }

        public void cargarPais()
        {
            this.paisTableAdapter.Fill(this.dataSetBanco.pais);
        }

        public void cargarTabla()
        {
            this.listarDepartamentoTableAdapter.Fill(this.dataSetBanco.listarDepartamento);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            cbPais.SelectedValue = 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String descr = txtDescripcion.Text;
            Int32 idPais = (Int32)cbPais.SelectedValue;
            if (nombre != "")
            {
                if (descr != "")
                {
                    if (idPais != 1)
                    {
                        if (ctlDepto.SolicitudGuardarDepartamento(nombre, descr, idPais))
                        {
                            MessageBox.Show("Exito al registrar");
                            deshabilitarCampos();
                            cargarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error--");
                            deshabilitarCampos();
                        }
                    }
                    else
                        MessageBox.Show("Seleccione el País al que pertenece el Departamento");
                }
                else
                    MessageBox.Show("Por favor ingrese la descripcion");
            }
            else
                MessageBox.Show("De un nombre por favor");

        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String descr = txtDescripcion.Text;
            Int32 idPais = (Int32)cbPais.SelectedValue;

            if (nombre != "")
            {
                if (descr != "")
                {
                    if (idPais != 1)
                    {
                        if (ctlDepto.SolicitudModificarDepartamento(nombre, descr, idPais))
                        {
                            MessageBox.Show("Exito al editar");
                            deshabilitarCampos();
                            cargarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error--");
                            deshabilitarCampos();
                        }
                    }
                    else
                        MessageBox.Show("Seleccione el País al que pertenece el Departamento");
                }
                else
                    MessageBox.Show("Por favor ingrese la descripcion");
            }
            else
                MessageBox.Show("De un nombre por favor");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ctlDepto.solicitudEliminarPais(aux))
            {
                MessageBox.Show("Eliminado con exito");
                deshabilitarCampos();
                aux = 0;
                cargarTabla();
            }
            else
            {
                MessageBox.Show("Error--");
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                String nombre = txtNombre.Text;
                if (nombre.Length != 0)
                {
                    Departamento dep = ctlDepto.SolicitudBuscarDepartamento(nombre);
                    if (dep != null)
                    {

                        cbPais.SelectedValue = dep.getPaisId();
                        txtDescripcion.Text = dep.getDescripcion();
                        aux = dep.getId();
                        habilitarCampos();
                        btnGuardar.Enabled = false;
                        btnEditar.Enabled = true;
                        btnEliminar.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe, por favor adicionalo");
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
            cbPais.Enabled = true;
            txtDescripcion.ReadOnly = false;
            txtNombre.ReadOnly = true;
        }

        public void deshabilitarCampos()
        {

            cbPais.Enabled = false;

            txtDescripcion.ReadOnly = true;
            txtNombre.ReadOnly = false;
            limpiar();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        //private void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    String nombre = txtNombre.Text;
        //    if (nombre == "")
        //    {
        //        MessageBox.Show("Complete la informacion");
        //    }
        //    else
        //    {
        //        Departamento dep = ctlDepto.SolicitudBuscarDepartamento(nombre);
        //        if (dep != null)
        //        {
        //            txtDescripcion.Text = dep.getDescripcion();
        //            cbPais.SelectedValue = dep.getPaisId();
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se encontro");
        //        }
        //    }
        //}
    }
}
