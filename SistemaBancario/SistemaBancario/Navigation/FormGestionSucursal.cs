using Platform.Comunication.controller;
using Platform.Object.model;
using SistemaBancario.Resources;
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
        CiudadController ciudadController = new CiudadController();
        public FormGestionSucursal()
        {
            InitializeComponent();
        }


        private void FormGestionSucursal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.banco' Puede moverla o quitarla según sea necesario.
            this.bancoTableAdapter.Fill(this.dataSetBanco.banco);

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
            BindingList<Item> deptos = new BindingList<Item>();
            for (int i = 0; i < lista.Count; i++)
            {
                deptos.Add(new Item((lista.ElementAt(i)).getNombre(), (lista.ElementAt(i)).getId()));
                
            }
            
            cBDepartamento.DisplayMember = "Name";
            cBDepartamento.ValueMember = "Value";
            cBDepartamento.DataSource = deptos;



        }

        private void cBDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item itm = (Item)cBDepartamento.SelectedItem;
            Int32 idPais = (int)cBPais.SelectedValue;
            LinkedList<Ciudad> lista = ciudadController.solicitudListaCiudadPorDeptos(itm.Value);
            BindingList<Item> ciudad = new BindingList<Item>();
            for (int i = 0; i < lista.Count; i++)
            {
                ciudad.Add(new Item((lista.ElementAt(i)).getNombre(), (lista.ElementAt(i)).getId()));

            }

            cBCiudad.DisplayMember = "Name";
            cBCiudad.ValueMember = "Value";
            cBCiudad.DataSource = ciudad;
            
        }

        public void cargarComboGerente() { 
        
        }

        private void tBNombre_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("algo");
        }

        private void tBNombre_TextChanged(object sender, EventArgs e)
        {

        }

      

    }
}
