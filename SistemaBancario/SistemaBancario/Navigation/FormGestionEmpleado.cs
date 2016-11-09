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
using SistemaBancario.Resources;
namespace SistemaBancario.Navigation
{
    public partial class FormGestionEmpleado : Form
    {

        EmpleadoController ctlEmp;
        UsuarioController ctlUsu;
        DepartamentoController deptoController = new DepartamentoController();
        CiudadController ciudadController = new CiudadController();
        int aux;
        public FormGestionEmpleado()
        {
            InitializeComponent();
            ctlEmp = new EmpleadoController();
            ctlUsu = new UsuarioController();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resp;
            String cedula = txtCedula.Text;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            txtPrueba.Text = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd");
            String fecha = txtPrueba.Text;
            Int32 idCiudad = (Int32)cbCiudad.SelectedValue;
            Int32 idCargo = (Int32)cbCrgo.SelectedValue;
            String cuenta = txtCuenta.Text;
            String contraseña = txtContraseña.Text;
            Int32 idTipoUsu = (Int32)cbTipoUsuario.SelectedValue;
            Int32 idSucursal = (Int32)cbSucursal.SelectedValue;

            if (cedula == "" || nombre == "" || apellido == "" || cuenta == "" || contraseña == "")
            {
                MessageBox.Show("Ingrese la infomacion completa");
            }
            else
            {
                resp = ctlUsu.SolicitudGuardarUsuario(cuenta, contraseña, idTipoUsu);
                Usuario usua = ctlUsu.SolicitudObtenerIdUsuario(cuenta);
                Int32 idUsu = usua.getId();
                if (resp = true && ctlEmp.SolicitudGuardarEmpleado(nombre, apellido, cedula,
                    fecha, idCiudad, idSucursal, idCargo, idUsu))
                {
                    MessageBox.Show("Exito al registrar al empleado");
                    cargarTabla();
                }
            }


        }

        private void FormGestionEmpleado_Load(object sender, EventArgs e)
        {
            cargarTabla();

            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.pais' Puede moverla o quitarla según sea necesario.
            this.paisTableAdapter.Fill(this.dataSetBanco.pais);
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.cargo' Puede moverla o quitarla según sea necesario.
            this.cargoTableAdapter.Fill(this.dataSetBanco.cargo);
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.sucursal' Puede moverla o quitarla según sea necesario.
            this.sucursalTableAdapter.Fill(this.dataSetBanco.sucursal);
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.tipo_usuario' Puede moverla o quitarla según sea necesario.
            this.tipo_usuarioTableAdapter.Fill(this.dataSetBanco.tipo_usuario);
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dataSetBanco.usuario);
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.ciudad' Puede moverla o quitarla según sea necesario.
            this.ciudadTableAdapter.Fill(this.dataSetBanco.ciudad);

        }

        public void cargarTabla()
        {
            this.empleadoTableAdapter.Fill(this.dataSetBanco.empleado);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            String cedula = txtCedula.Text;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            txtPrueba.Text = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd");
            String fecha = txtPrueba.Text;
            Int32 idCiudad = (Int32)cbCiudad.SelectedValue;
            Int32 idCargo = (Int32)cbCrgo.SelectedValue;
            String cuenta = txtCuenta.Text;
            String contraseña = txtContraseña.Text;
            Int32 idTipoUsu = (Int32)cbTipoUsuario.SelectedValue;
            Int32 idSucursal = (Int32)cbSucursal.SelectedValue;
            if (cedula == "" || nombre == "" || apellido == "" ||  cuenta == "" || contraseña == "")
            {
                MessageBox.Show("Complete la informacion por favor.");
            }
            else
            {
                Empleado epl = new Empleado();
                epl = ctlEmp.SolicitudBuscarEmpleado(cedula);
                Int32 idUsu = epl.getUsuarioId();
                Empleado emp = new Empleado(nombre, apellido, cedula, fecha, idCiudad, idSucursal, idCargo, idUsu);
                Usuario usu = new Usuario(cuenta, contraseña, idTipoUsu);
                if (ctlEmp.SolicitudModificarEmpleado(cedula, nombre, apellido, fecha,
                idCiudad, idCargo, idSucursal, cuenta, contraseña, idUsu, idTipoUsu))
                {
                    MessageBox.Show("Exito");
                    cargarTabla();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String cedu = txtCedula.Text;
            Int32 idAux;
            if (cedu == "")
            {
                MessageBox.Show("Para eliminar, porfavor ingrese la cedula");
            }
            else
            {
                Empleado emp = new Empleado();
                emp = ctlEmp.SolicitudBuscarEmpleado(cedu);
                idAux = emp.getUsuarioId();
                if (ctlEmp.solicitudEliminarEmpleado(cedu))
                {
                    MessageBox.Show("Eliminado");
                }
                if (ctlUsu.solicitudEliminarUsuario(idAux))
                {
                    MessageBox.Show("Eliminado correctamente");
                }
                cargarTabla();
                deshabilitarCampos();
            }
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

                cbCiudad.DisplayMember = "Name";
                cbCiudad.ValueMember = "Value";
                cbCiudad.DataSource = ciudad;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String cedula = txtCedula.Text;
            if (cedula == "")
            {
                MessageBox.Show("Ingrese una cedula para poder buscar");
            }
            else
            {
                Empleado em = ctlEmp.SolicitudBuscarEmpleado(cedula);
                if (em != null)
                {
                    txtApellido.Text = em.getApellido();
                    txtNombre.Text = em.getNombre();
                    dtpFechaNacimiento.Text = em.getFechaNacimiento();
                    cbCiudad.SelectedValue = (int)em.getCiudadNacimiento();
                    cbCrgo.SelectedValue = (int)em.getCargoId();
                    cbSucursal.SelectedValue = (int)em.getSucursalId();
                    cbTipoUsuario.SelectedValue = em.nombreTipoUsu;
                    txtCuenta.Text = em.cuenta;
                }
                else
                {
                    MessageBox.Show("Error--");
                }
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                String cedula = txtCedula.Text;
                if (cedula.Length != 0)
                {
                    Empleado em = ctlEmp.SolicitudBuscarEmpleado(cedula);
                    if (em != null)
                    {

                        cBPais.SelectedValue = em.idPais;
                        cBDepartamento.SelectedValue = em.idDepartamento;
                        txtApellido.Text = em.getApellido();
                        txtNombre.Text = em.getNombre();
                        dtpFechaNacimiento.Text = em.getFechaNacimiento();
                        cBPais.SelectedValue = em.idPais;
                        cBDepartamento.SelectedValue = em.idDepartamento;
                        cbCiudad.SelectedValue = em.getCiudadNacimiento();
                        cbCrgo.SelectedValue = (int)em.getCargoId();
                        cbSucursal.SelectedValue = (int)em.getSucursalId();
                        cbTipoUsuario.SelectedValue = em.nombreTipoUsu;
                        txtCuenta.Text = em.cuenta;
                        aux = em.getId();
                        habilitarCampos();
                        btnGuardar.Enabled = false;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("El Empleado no existe, por favor adicionalo");
                        habilitarCampos();
                        btnGuardar.Enabled = true;
                        btnModificar.Enabled = false;
                        btnEliminar.Enabled = false;

                    }


                }
            }
        }
        public void habilitarCampos()
        {
            cbCiudad.Enabled = true;
            cBDepartamento.Enabled = true;
            cBPais.Enabled = true;
            cbSucursal.Enabled = true;
            cbCrgo.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            txtCedula.ReadOnly = true;
            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtCuenta.ReadOnly = false;
            txtContraseña.ReadOnly = false;
            cbTipoUsuario.Enabled = true;
        }


        public void deshabilitarCampos()
        {
            cbCiudad.Enabled = false;
            cBDepartamento.Enabled = false;
            cBPais.Enabled = false;
            cbSucursal.Enabled = false;
            cbCrgo.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            txtCedula.ReadOnly = false;
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtCuenta.ReadOnly = true;
            txtContraseña.ReadOnly = true;
            cbTipoUsuario.Enabled = false;
            limpiarCampos();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        public void limpiarCampos()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCuenta.Text = "";
            txtContraseña.Text = "";
            cBPais.SelectedValue = 1;

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
