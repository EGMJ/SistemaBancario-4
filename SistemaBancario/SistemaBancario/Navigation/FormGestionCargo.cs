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
    public partial class FormGestionCargo : Form
    {
        CargoController ctlCargo;
        public FormGestionCargo()
        {
            InitializeComponent();
            ctlCargo = new CargoController();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombreCargo.Text;
            Double salario = Convert.ToDouble(txtSalario.Text);
            Int32 cantidadH = Convert.ToInt32(txtIntensidad.Text);
            String descri = txtDescripcion.Text;

            if(nombre == "" || salario.Equals("") || cantidadH.Equals("")){
                MessageBox.Show("Porfavor complete toda la informacion");
            }
            else
            {
                if(ctlCargo.SolicitudGuardarCargo(nombre,salario,cantidadH,descri)){
                    MessageBox.Show("Se registro el cargo: " + nombre);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error---");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombreCargo.Text;
            Cargo c = new Cargo();
            c = ctlCargo.SolicitudBuscarCargo(nombre);
            if(c != null){
                txtIntensidad.Text = Convert.ToString(c.getCantidadHoras());
                txtSalario.Text = Convert.ToString(c.getSalario());
                txtDescripcion.Text = c.getDescripcion();
                btnEliminar.Enabled = true;
                btnEditar.Enabled = true;
                txtNombreCargo.Enabled = false;
                btnGuardar.Enabled = false;
                btnBuscar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error..");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            String nombre = txtNombreCargo.Text;
            double salario = Convert.ToDouble(txtSalario.Text);
            Int32 cantidadH = Convert.ToInt32(txtIntensidad.Text);
            String descri = txtDescripcion.Text;

            if (nombre == "" || salario.Equals("") || cantidadH.Equals(""))
            {
                MessageBox.Show("Porfavor complete toda la informacion");
            }
            else
            {
                if (ctlCargo.SolicitudModificarCargo(nombre, salario, cantidadH, descri))
                {
                    MessageBox.Show("Se modifico con exito");
                    limpiar();
                    btnBuscar.Enabled = true;
                    btnGuardar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Erro--");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombreCargo.Text;
            if(ctlCargo.solicitudEliminarCargo(nombre)){
                MessageBox.Show("Se elimino");
                limpiar();
                btnBuscar.Enabled = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }

        public void limpiar()
        {
            txtNombreCargo.Text = "";
            txtIntensidad.Text = "";
            txtSalario.Text = "";
            txtDescripcion.Text = "";
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtNombreCargo.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
