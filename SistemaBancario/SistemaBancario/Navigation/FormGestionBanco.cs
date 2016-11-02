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
        PoliticaController ctlPolitica;
        public FormGestionBanco()
        {
            InitializeComponent();
            ctlBanco = new BancoController();
            ctlPolitica = new PoliticaController();
            Banco b = new Banco();
            Politica p = new Politica();
            p = ctlPolitica.solicitudObtenerPolitica();
            b = ctlBanco.solicitudObtenerBanco();
            txtNit.Text = b.getNit();
            txtNombreBanco.Text = b.getNombre();
            txtDescrpcion.Text = b.getDescripcion();
            txtMision.Text = p.getMision();
            txtVision.Text = p.getVision();
        } 

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String nit = txtNit.Text;
            String nombre = txtNombreBanco.Text;
            String descripcion = txtDescrpcion.Text;
            String mision = txtMision.Text;
            String vision = txtVision.Text;
            if(nombre =="" || nit == ""){
                MessageBox.Show("Accion Invalida!");
            }
            else
            {
                if(ctlBanco.SolicitudModificarBanco(nit,nombre,descripcion) &&
                    ctlPolitica.SolicitudModificarBanco(mision, vision))
                {                  
                        MessageBox.Show("Se modifico con exito.");            
                }
            }
        }
     
        private void FormGestionBanco_Load(object sender, EventArgs e)
        {

        }
    }
}
