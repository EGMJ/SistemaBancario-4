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
    public partial class FormGestionBanco : Form
    {
        BancoController ctlBanco;
        public FormGestionBanco()
        {
            InitializeComponent();
            ctlBanco = new BancoController();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nit = txtNit.Text;
            String nombre = txtNombreBanco.Text;
            String descripcion = txtDescrpcion.Text;
            if(nit=="" || nombre == ""){
                MessageBox.Show("Porfavor complete la informacion.");
            }
            else
            {
                Banco b = ctlBanco.SolicitudBuscarBanco(nit);
                if(b != null){
                    MessageBox.Show("Ya existe un Banco con este NIT");
                }
                else
                {
                    if (ctlBanco.SolicitudGuardarBanco(nit, nombre, descripcion))
                    {
                        MessageBox.Show("Se registro con exito");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error--");
                    }
                }                
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nit = txtNit.Text;
            if(nit ==""){
                MessageBox.Show("Ingrese el NIT para poder buscar");
            }
            else
            {
                Banco b = ctlBanco.SolicitudBuscarBanco(nit);
                if(b != null){
                    MessageBox.Show("Se encontro el Banco.");
                    txtNit.Enabled = false;
                    txtNit.Text = b.getNit();
                    txtNombreBanco.Text = b.getNombre();
                    txtDescrpcion.Text = b.getDescripcion();
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No existe el Banco.");
                }
            }
        }

        public void limpiar()
        {
            txtDescrpcion.Text = "";
            txtMision.Text = "";
            txtNit.Text = "";
            txtNombreBanco.Text = "";
            txtVision.Text = "";
            txtNit.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String nit = txtNit.Text;
            String nombre = txtNombreBanco.Text;
            String descripcion = txtDescrpcion.Text;
            if(nombre ==""){
                MessageBox.Show("Accion Invalida!");
                limpiar();
            }
            else
            {
                if(ctlBanco.SolicitudModificarBanco(nit,nombre,descripcion)){
                    MessageBox.Show("Se modifico con exito.");
                    limpiar();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String nit = txtNit.Text;
            if(ctlBanco.solicitudEliminarBanco(nit)){
                MessageBox.Show("Se elimino satisfactoriamente.");
                limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void FormGestionBanco_Load(object sender, EventArgs e)
        {

        }




    }
}
