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

    public partial class c : Form
    {

        CiudadController ctlCiudad;
        public c()
        {
            InitializeComponent();
            ctlCiudad = new CiudadController();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }     

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /**
             * String nombre = txtNombreCiudad.Text;
             * Int32 id_depto= cbDepto.algo;
             * String descripcion = txtDescripcion.Text;
             * if(nombre =="" || id_depto == vacio){
             *      MessageBox.Show("Debe completar la informacion");
             * }else{
             *      Ciudad city = ctlSolicitudBuscarCiudad(nombre);
             *      if(city != null){
             *          MessageBox.Show("Ya existe una ciudad con este nombre");
             *      }else{
             *          if(ctlSolicitudGuardaCiudad(nombre,id_depto,descripcion)){
             *              MessageBox.Show("Se registro con exito");
             *              limpiar();
             *          }else{
             *              MessageBox.Show("Erro---");
             *          }
             *      }
             * 
             * }
             **/
        }

        public void limpiar()
        {
            txtNombreCiudad.Text = "";
            txtDescripcion.Text = "";
            cbDepto.SelectedIndex = 0;
            txtNombreCiudad.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
                   
            String nombre = txtNombreCiudad.Text;
            if(nombre == ""){
                  MessageBox.Show("Ingrese el nombre de la ciudad que quiere buscar");
             }else{
                 Ciudad c = ctlCiudad.SolicitudBuscarCiudad(nombre);
                  if(c != null){
                      //  txtNombreCiudad.Text = c.getNombre();
                      txtDescripcion.Text = c.getDescripcion();
                     txtNombreCiudad.Enabled = false;
                 }else{
                      MessageBox.Show("No se pudo encontrar.");
                  }
             }
     
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            /**
             *String nombre = txtNombreCiudad.Text;
             *String descr = txtDescripcion.Text;
             *Int32 id_depto = cbDepto.getSelectIndex;
             *if(id_depto == 0){
             *      MessageBox.Show("Porfavor complete la informacion");
             * }else{
             *  if(ctlCiudad.solicitudEditarCiudad(nombre,descr,id_depto)){
             *      MessageBox.Show("Se actualizo la ciudad");
             *      limpiar();
             *  }else{
             *       MessageBox.Show("Error----");
             * }
             * }
             *
             **/


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombreCiudad.Text;
            if(nombre == ""){
                MessageBox.Show("Debe Ingresar el nombre para eliminar la ciudad");
            }
            else
            {
                if(ctlCiudad.solicitudEliminarCiudad(nombre)){
                    MessageBox.Show("Se elimino la ciudad");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error--");
                }
            }
        }
    }
}
