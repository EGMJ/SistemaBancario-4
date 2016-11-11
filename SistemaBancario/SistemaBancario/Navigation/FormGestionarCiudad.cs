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
using SistemaBancario.Resources;
namespace SistemaBancario.Navigation
{

    public partial class c : Form
    {
        DepartamentoController deptoController = new DepartamentoController();
        CiudadController ctlCiudad;
        int aux;
        public c()
        {
            InitializeComponent();
            ctlCiudad = new CiudadController();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            String nombre = txtNombreCiudad.Text;
            Int32 id_depto = (Int32)cbDepto.SelectedValue;
            String descripcion = txtDescripcion.Text;
            if (nombre == "" || id_depto == 0)
            {
                MessageBox.Show("Debe completar la informacion");
            }
            else
            {                
                if (ctlCiudad.SolicitudGuardarCiudad(nombre, descripcion, id_depto))
                {
                    MessageBox.Show("Se registro con exito");
                    
                    deshabilitarCampos();
                    cargarTabla();
                }
                else
                {
                    MessageBox.Show("Erro---");
                }

            }

        }

        public void limpiar()
        {
            txtNombreCiudad.Text = "";
            txtDescripcion.Text = "";
            cbDepto.SelectedIndex = 0;
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            String nombre = txtNombreCiudad.Text;
            if (nombre == "")
            {
                MessageBox.Show("Ingrese el nombre de la ciudad que quiere buscar");
            }
            else
            {
                Ciudad c = ctlCiudad.SolicitudBuscarCiudad(nombre);
                if (c != null)
                {
                    //  txtNombreCiudad.Text = c.getNombre();
                    txtDescripcion.Text = c.getDescripcion();
                    cbDepto.SelectedValue = (int)c.getIdDepartamento();
                    txtNombreCiudad.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar.");
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            String nombre = txtNombreCiudad.Text;
            String descr = txtDescripcion.Text;
            Int32 id_depto = (int)cbDepto.SelectedValue;
            if (id_depto == 0 || nombre == "")
            {
                MessageBox.Show("Porfavor complete la informacion");
            }
            else
            {
                if (ctlCiudad.SolicitudModificarCiudad(nombre, descr, id_depto))
                {
                    MessageBox.Show("Se actualizo la ciudad");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error----");
                }
            }




        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombreCiudad.Text;
            if (nombre == "")
            {
                MessageBox.Show("Debe Ingresar el nombre para eliminar la ciudad");
            }
            else
            {
                if (ctlCiudad.solicitudEliminarCiudad(nombre))
                {
                    MessageBox.Show("Se elimino la ciudad");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error--");
                }
            }
        }

        private void c_Load(object sender, EventArgs e)
        {
            cargarTabla();
           
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.pais' Puede moverla o quitarla según sea necesario.
            this.paisTableAdapter.Fill(this.dataSetBanco.pais);
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.dataSetBanco.departamento);

        }

        private void cbDepto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBPais.SelectedValue != null)
            {
                Int32 idPais = (int)cBPais.SelectedValue;
                LinkedList<Departamento> lista = deptoController.solicitudListaDeptosPorPais(idPais);
                BindingList<Item> deptos = new BindingList<Item>();
                for (int i = 0; i < lista.Count; i++)
                {
                    deptos.Add(new Item((lista.ElementAt(i)).getNombre(), (lista.ElementAt(i)).getId()));

                }

                cbDepto.DisplayMember = "Name";
                cbDepto.ValueMember = "Value";
                cbDepto.DataSource = deptos;
            }

        }

        private void txtNombreCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                String nombre = txtNombreCiudad.Text;
                if (nombre.Length != 0)
                {
                    Ciudad c = ctlCiudad.SolicitudBuscarCiudad(nombre);
                    if (c != null)
                    {
                        //  txtNombreCiudad.Text = c.getNombre();
                        txtDescripcion.Text = c.getDescripcion();
                        cbDepto.SelectedValue = (int)c.getIdDepartamento();
                        cBPais.SelectedValue = c.idPais;
                        txtDescripcion.Text = c.getDescripcion();
                        aux = c.getId();
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

            cbDepto.Enabled = true;
            cBPais.Enabled = true;
            txtDescripcion.ReadOnly = false;
            txtNombreCiudad.ReadOnly = true;
        }
        public void deshabilitarCampos()
        {
            
            cbDepto.Enabled = false;
            cBPais.Enabled = false;
            
            txtDescripcion.ReadOnly = true;
            txtNombreCiudad.ReadOnly = false;
            limpiar();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        public void cargarTabla()
        {
            this.ciudadTableAdapter.Fill(this.dataSetBanco.ciudad);
        }

        private void txtNombreCiudad_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
