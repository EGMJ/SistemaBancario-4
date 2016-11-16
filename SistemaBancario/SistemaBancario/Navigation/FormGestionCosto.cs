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
namespace SistemaBancario
{
    public partial class FormGestionCosto : Form
    {
        CostoController ctlCos;
        int aux;

        public FormGestionCosto()
        {
            InitializeComponent();
            ctlCos = new CostoController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            double monto = Convert.ToDouble(txtCosto.Text);
            if(nombre!=""){
                if(!monto.Equals("")){
                    if(ctlCos.SolicitudGuardarCosto(nombre,monto)){
                        MessageBox.Show("Exito al registrar");
                    }
                    else
                    {
                        MessageBox.Show("Error...");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un monto porfavor");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre porfavor");
            }
        }

       

        private void FormGestionCosto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.costo' Puede moverla o quitarla según sea necesario.
            this.costoTableAdapter.Fill(this.dataSetBanco.costo);

        }

        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                String nombre = txtNombre.Text;
                if (nombre.Length != 0)
                {
                    Costo c = ctlCos.SolicitudBuscarCosto(nombre);
                    if (c != null)
                    {
                        txtCosto.Text = c.getMonto().ToString();
                        aux = c.getId();
                        //habilitarCampos();
                        //btnGuardar.Enabled = false;
                        //btnEditar.Enabled = true;
                        //btnEliminar.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("El costo no existe, por favor adicionalo");
                        //habilitarCampos();
                        //btnGuardar.Enabled = true;
                        //btnEditar.Enabled = false;
                        //btnEliminar.Enabled = false;
                    }
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
