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

        public FormGestionPais()
        {
            InitializeComponent();
            ctlPais = new PaisController();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String descr = txtDescripcion.Text; 
            if(nombre == ""){
                MessageBox.Show("Escriba el nombre");
            }
            else
            {
                if(ctlPais.SolicitudGuardarPais(nombre,descr)){
                    MessageBox.Show("Exito al registrar");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error..");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            if(nombre == ""){
                MessageBox.Show("Escriba el nombre porfavor");
            }
            else
            {
                Pais p = ctlPais.SolicitudBuscarPais(nombre);
                if(p != null){
                    txtDescripcion.Text = p.getDescripcion();
                }
                else
                {
                    MessageBox.Show("Error--");
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
                    limpiar();
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
            if(nombre == ""){
                MessageBox.Show("Escriba el nombre");
            }else
            {
                if(ctlPais.solicitudEliminarPais(nombre)){
                    MessageBox.Show("Eliminado con exito");
                    limpiar();
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
    }
}
