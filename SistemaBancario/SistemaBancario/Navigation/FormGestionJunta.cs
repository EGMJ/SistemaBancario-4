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
    public partial class FormGestionJunta : Form
    {
         DepartamentoController deptoController = new DepartamentoController();
        CiudadController ciudadController = new CiudadController();
        EmpleadoController empleadoController = new EmpleadoController();
        BancoController banco = new BancoController();
        SucursalController sucursalrControlador = new SucursalController();
        PaisController paisControlador = new PaisController();
        public FormGestionJunta()
        {
            InitializeComponent();
        }

        private void cBPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBPais.SelectedValue != null)
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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormGestionJunta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.pais' Puede moverla o quitarla según sea necesario.
            this.paisTableAdapter.Fill(this.dataSetBanco.pais);

        }

        private void cBDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item itm = (Item)cBDepartamento.SelectedItem;
            if (itm != null)
            {
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
        }
    }
}
