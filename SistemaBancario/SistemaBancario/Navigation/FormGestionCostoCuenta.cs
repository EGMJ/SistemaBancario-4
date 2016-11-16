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
    public partial class FormGestionCostoCuenta : Form
    {

        TipoCuentaCostoController ctlCtt;
        int aux;
        public FormGestionCostoCuenta()
        {
            InitializeComponent();
            ctlCtt =  new TipoCuentaCostoController();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Int32 cuenta = (Int32)cbCuenta.SelectedValue;
            Int32 costo = (Int32)cbMonto.SelectedValue;

            if(ctlCtt.SolicitudGuardarCuentaCosto(cuenta,costo)){
                MessageBox.Show("Exito al guardar");
            }
        }

        private void FormGestionCostoCuenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.costo' Puede moverla o quitarla según sea necesario.
            this.costoTableAdapter.Fill(this.dataSetBanco.costo);
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.tipo_cuenta' Puede moverla o quitarla según sea necesario.
            this.tipo_cuentaTableAdapter.Fill(this.dataSetBanco.tipo_cuenta);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Int32 cuenta = (Int32)cbCuenta.SelectedValue;
            Int32 costo = (Int32)cbMonto.SelectedValue;
            if(ctlCtt.SolicitudModificarCuentaCos(aux,cuenta,costo)){
                MessageBox.Show("Edita con exito");
                aux = 0;
            }
        }

        private void cbCuenta_SelectedIndexChanged(object sender,
        System.EventArgs e)
        {
            Int32 cuenta = (Int32)cbCuenta.SelectedValue;
            TipoCuentaCosto tcc = ctlCtt.SolicitudBuscarCuenCos(cuenta);
            if(tcc != null){
                cbMonto.SelectedValue = tcc.getCostoId();
                aux = tcc.getId();
                MessageBox.Show("Encontrado");
            }
            else
            {
                MessageBox.Show("No existe");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(ctlCtt.solicitudEliminarCuentaCosto(aux)){
                MessageBox.Show("Eliminado con exito");
                aux = 0;
            }
        }
    }
}
