using Platform.Comunication.controller;
using Platform.Object.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario.Navigation
{
    public partial class FormGestionSucursal : Form
    {
        DepartamentoController deptoController = new DepartamentoController();
        public FormGestionSucursal()
        {
            InitializeComponent();
        }
        

        private void FormGestionSucursal_Load(object sender, EventArgs e)
        {
           
            this.departamentoTableAdapter.Fill(this.dataSetBanco.departamento);
            cargarPais();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        public void cargarPais()
        {
            this.paisTableAdapter.Fill(this.dataSetBanco.pais);
        }

        private void cBPais_SelectedIndexChanged(object sender, EventArgs e)
        {
           Int32 idPais = (int)cBPais.SelectedValue;
           LinkedList<Departamento> lista = deptoController.solicitudListaDeptosPorPais(idPais);
           for (int i = 0; i < lista.Count;i++ )
           {
               cBDepartamento.SelectedItem = (lista.ElementAt(i)).getNombre();
               //String nombre = lista.ElementAt(i)).getNombre();
               cBDepartamento.SelectedValue = (lista.ElementAt(i)).getId();
               MessageBox.Show((lista.ElementAt(i)).getNombre() + "");
           }
            
           
        }
    }
}
