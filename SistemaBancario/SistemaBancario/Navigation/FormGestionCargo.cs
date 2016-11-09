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
        int aux;
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
                    deshabilitarCampos();
                    cargarTabla();
                    
                }
                else
                {
                    MessageBox.Show("Error---");
                }
            }
        }

        //private void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    String nombre = txtNombreCargo.Text;
        //    Cargo c = ctlCargo.SolicitudBuscarCargo(nombre);
        //    if(c != null){
        //        txtIntensidad.Text = Convert.ToString(c.getCantidadHoras());
        //        txtSalario.Text = Convert.ToString(c.getSalario());
        //        txtDescripcion.Text = c.getDescripcion();
        //        btnEliminar.Enabled = true;
        //        btnEditar.Enabled = true;
        //        txtNombreCargo.Enabled = false;
        //        btnGuardar.Enabled = false;
        //        btnBuscar.Enabled = false;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error..");
        //    }
        //}

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
                    deshabilitarCampos();
                    cargarTabla();
                                      
                }
                else
                {
                    MessageBox.Show("Erro--");
                    //deshabilitarCampos();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombreCargo.Text;
            if(ctlCargo.solicitudEliminarCargo(nombre)){
                MessageBox.Show("Se elimino");
                deshabilitarCampos();
                cargarTabla();
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

        private void txtNombreCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                String nombre = txtNombreCargo.Text;
                if (nombre.Length != 0)
                {                 
                    Cargo c = ctlCargo.SolicitudBuscarCargo(nombre);
                    if (c != null)
                    {
                        txtIntensidad.Text = Convert.ToString(c.getCantidadHoras());
                        txtSalario.Text = Convert.ToString(c.getSalario());
                        txtDescripcion.Text = c.getDescripcion();
                        aux = c.getId();
                        habilitarCampos();
                        btnGuardar.Enabled = false;
                        btnEditar.Enabled = true;
                        btnEliminar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingresa el cargo");
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
            txtIntensidad.ReadOnly = false;
            txtSalario.ReadOnly = false;
            txtNombreCargo.ReadOnly = true;
        }
        public void deshabilitarCampos()
        {

            txtDescripcion.ReadOnly = true;
            txtIntensidad.ReadOnly = true;
            txtSalario.ReadOnly = true;
            txtNombreCargo.ReadOnly = false;
            limpiar();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void FormGestionCargo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.cargo' Puede moverla o quitarla según sea necesario.
            cargarTabla();

        }

        public void cargarTabla()
        {
            this.cargoTableAdapter.Fill(this.dataSetBanco.cargo);
        }
    }
}
