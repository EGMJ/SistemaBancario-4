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
        JuntaDirectivaController juntaControlador = new JuntaDirectivaController();
        DepartamentoController deptoController = new DepartamentoController();
        CiudadController ciudadController = new CiudadController();
        BancoController banco = new BancoController();
        int aux;
        public FormGestionJunta()
        {
            InitializeComponent();
        }

        private void FormGestionJunta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.listarJunta' Puede moverla o quitarla según sea necesario.
            cargarTabla();
            cargarPais();


        }
        public void cargarPais()
        {
            this.paisTableAdapter.Fill(this.dataSetBanco.pais);
        }
        private void tBCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                String cedula = tBCedula.Text;
                if (cedula.Length != 0)
                {
                    MiembroJuntaDirectiva junta = juntaControlador.solicitudBuscar(cedula);
                    if (junta != null)
                    {

                        cBPais.SelectedValue = junta.idPais;
                        cBDepartamento.SelectedValue = junta.idDepartamento;
                        cBCiudad.SelectedValue = junta.getCiudadNacimiento();
                        tBNombre.Text = junta.getNombre();
                        tBApellido.Text = junta.getApellido();
                        tBacciones.Text = junta.getAcciones().ToString();
                        dTPFecha.Text = junta.getFechaNacimiento();
                        aux = junta.getId();
                        habilitarCampos();
                        btnGuardar.Enabled = false;
                        btnEditar.Enabled = true;
                        btnEliminar.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe, por favor adicionalo");
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
            cBCiudad.Enabled = true;
            cBDepartamento.Enabled = true;
            cBPais.Enabled = true;
            dTPFecha.Enabled = true;
            tBNombre.ReadOnly = false;
            tBApellido.ReadOnly = false;
            tBacciones.ReadOnly = false;
            tBCedula.ReadOnly = true;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Int32 ciudadId;
            if (tBNombre.Text != "" || tBApellido.Text != "")
            {
                if ((cBCiudad.SelectedItem) != null)
                {
                    if ((((Item)cBCiudad.SelectedItem).Value) != -1)
                    {
                        if (dTPFecha.Text != "")
                        {
                            if (tBacciones.Text != "")
                            {
                                String cedula = tBCedula.Text;
                                String nombre = tBNombre.Text.ToUpper();
                                String apellido = tBApellido.Text.ToUpper();
                                double acciones = Convert.ToDouble(tBacciones.Text);
                                Int32 bancoId = (banco.solicitudObtenerBanco()).getId();
                                String fecha = dTPFecha.Value.ToString("yyyy-MM-dd");
                                ciudadId = ((Item)cBCiudad.SelectedItem).Value;
                                String info = juntaControlador.solicitudGuardar(-1, acciones, nombre, apellido, cedula, fecha, ciudadId, bancoId);
                                MessageBox.Show(info);
                                if (!info.Equals("Las acciones se han sobre pasado"))
                                {
                                    deshabilitarCampos();
                                    cargarTabla();
                                }


                            }
                            else
                                MessageBox.Show("Por favor ingresa las acciones para el miembro de la junto");
                        }
                        else
                            MessageBox.Show("Por favor ingresa la fecha de nacimiento");
                    }
                    else
                        MessageBox.Show("Por favor selecciona la ciudad");
                }
                else
                    MessageBox.Show("Por favor selecciona la ciudad");
            }
            else
                MessageBox.Show("Por favor ingresa el nombre o apellido del nuevo miembro de la junta directiva");

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Int32 ciudadId;
            if (tBNombre.Text != "" || tBApellido.Text != "")
            {
                if ((cBCiudad.SelectedItem) != null)
                {
                    if ((((Item)cBCiudad.SelectedItem).Value) != -1)
                    {
                        if (dTPFecha.Text != "")
                        {
                            if (tBacciones.Text != "")
                            {
                                String cedula = tBCedula.Text;
                                String nombre = tBNombre.Text.ToUpper();
                                String apellido = tBApellido.Text.ToUpper();
                                double acciones = Convert.ToDouble(tBacciones.Text);
                                Int32 bancoId = (banco.solicitudObtenerBanco()).getId();
                                String fecha = dTPFecha.Value.ToString("yyyy-MM-dd");
                                ciudadId = ((Item)cBCiudad.SelectedItem).Value;
                                String info = juntaControlador.solicitudGuardar(aux, acciones, nombre, apellido, cedula, fecha, ciudadId, bancoId);
                                MessageBox.Show(info);
                                if (!info.Equals("Las acciones se han sobre pasado"))
                                {
                                    deshabilitarCampos();
                                    cargarTabla();
                                }


                            }
                            else
                                MessageBox.Show("Por favor ingresa las acciones para el miembro de la junto");
                        }
                        else
                            MessageBox.Show("Por favor ingresa la fecha de nacimiento");
                    }
                    else
                        MessageBox.Show("Por favor selecciona la ciudad");
                }
                else
                    MessageBox.Show("Por favor selecciona la ciudad");
            }
            else
                MessageBox.Show("Por favor ingresa el nombre o apellido del nuevo miembro de la junta directiva");

        }




        public void deshabilitarCampos()
        {
            cBCiudad.Enabled = false;
            cBDepartamento.Enabled = false;
            cBPais.Enabled = false;
            tBNombre.ReadOnly = true;
            tBApellido.ReadOnly = true;
            tBacciones.ReadOnly = true;
            tBCedula.ReadOnly = false;
            dTPFecha.Enabled = true;
            limpiarCampos();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        public void limpiarCampos()
        {
            tBNombre.Text = "";
            tBacciones.Text = "";
            tBApellido.Text = "";
            tBCedula.Text = "";
            cBPais.SelectedValue = 1;

        }

        public void cargarTabla()
        {
            this.listarJuntaTableAdapter.Fill(this.dataSetBanco.listarJunta);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String info = juntaControlador.solicutudEliminar(aux);
            MessageBox.Show(info);
            deshabilitarCampos();
            aux = 0;
            cargarTabla();
        }
    }
}
