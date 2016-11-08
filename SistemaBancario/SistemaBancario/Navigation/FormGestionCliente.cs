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
    public partial class FormGestionCliente : Form
    {

        ClienteController ctlCli;
        UsuarioController ctlUsu;
        public FormGestionCliente()
        {
            InitializeComponent();
            ctlCli = new ClienteController();
            ctlUsu = new UsuarioController();
        }

        private void FormGestionCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String cedula = txtCedula.Text;
            txtPrueba2.Text = dtpFecha.Value.ToString("yyyy-MM-dd");
            String fecha = txtPrueba2.Text;

            String cuenta = txtCuenta.Text;
            String contra = txtContraseña.Text;
            Int32 idTipoUsu = 5;

            if (nombre == "" | apellido == "" | cedula == "" | fecha == "" | cuenta == "" | contra == "")
            {
                MessageBox.Show("Porfavor complete la informacion");
            }
            else
            {
                if (ctlUsu.SolicitudGuardarUsuario(cuenta, contra, idTipoUsu))
                {

                }
                Usuario u = ctlUsu.SolicitudObtenerIdUsuario(cuenta);
                Int32 idAux = u.getId();
                if (ctlCli.SolicitudGuardarCliente(nombre, apellido, cedula, fecha, idAux))
                {
                    MessageBox.Show("Registrado con exito");
                    limpiar();
                }
            }
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCedula.Text = "";
            txtCuenta.Text = "";
            txtContraseña.Text = "";
        }
    }
}
