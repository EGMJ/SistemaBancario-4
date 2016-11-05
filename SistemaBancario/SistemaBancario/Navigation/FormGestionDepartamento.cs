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
        public FormGestionDepartamento()
        {
            InitializeComponent();
            ctlDepto = new DepartamentoController();
        }

        private void FormGestionDepartamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.pais' Puede moverla o quitarla según sea necesario.
            this.paisTableAdapter.Fill(this.dataSetBanco.pais);

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
            if(nombre == "" ){
                MessageBox.Show("De un nombre por favor");
            }
            else
            {
                if(ctlDepto.SolicitudGuardarDepartamento(nombre,descr,idPais)){
                    MessageBox.Show("Exito al registrar");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error--");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            if(nombre == ""){
                MessageBox.Show("Complete la informacion");
            }
            else
            {
                Departamento dep = ctlDepto.SolicitudBuscarDepartamento(nombre);
                if(dep != null){
                    txtDescripcion.Text = dep.getDescripcion();
                    cbPais.SelectedValue = dep.getPaisId();
                }
                else
                {
                    MessageBox.Show("No se encontro");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String descr = txtDescripcion.Text;
            Int32 idPais = (Int32)cbPais.SelectedValue;
            if (nombre == "")
            {
                MessageBox.Show("De un nombre por favor");
            }
            else
            {
                if (ctlDepto.SolicitudModificarDepartamento(nombre,descr,idPais))
                {
                    MessageBox.Show("Exito al editar");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error--");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            if(nombre == ""){
                MessageBox.Show("Complete la informacion");
            }
            else
            {
                if(ctlDepto.solicitudEliminarPais(nombre)){
                    MessageBox.Show("Eliminado con exito");
                    limpiar();
                }else
                {
                    MessageBox.Show("Error--");
                }
            }
        }
    }
}
