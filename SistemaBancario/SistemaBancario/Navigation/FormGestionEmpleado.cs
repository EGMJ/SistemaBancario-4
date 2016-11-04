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
    public partial class FormGestionEmpleado : Form
    {

        EmpleadoController ctlEmp;
        UsuarioController ctlUsu;

        public FormGestionEmpleado()
        {
            InitializeComponent();
            ctlEmp = new EmpleadoController();
            ctlUsu = new UsuarioController();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

            if (cedula == "" || nombre == "" || apellido == "" || cuenta == "" || contraseña == "")
            {
                MessageBox.Show("Ingrese la infomacion completa");
            }
            else
            {
                if (ctlUsu.SolicitudGuardarUsuario(cuenta, contraseña, idTipoUsu))
                {
                }
            }
            Usuario usua = ctlUsu.SolicitudObtenerIdUsuario(cuenta);
            Int32 idUsu = usua.getId();
            if (ctlEmp.SolicitudGuardarEmpleado(nombre, apellido, cedula, fecha, idCiudad, idSucursal, idCargo, idUsu))
            {
                MessageBox.Show("Exito al registrar al empleado");
            }

        }

        private void FormGestionEmpleado_Load(object sender, EventArgs e)
        {
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String cedula = txtCedula.Text;
            if (cedula == "")
            {
                MessageBox.Show("Ingrese una cedula para poder buscar");
            }
            else
            {
                Empleado em = new Empleado();
                em = ctlEmp.SolicitudBuscarEmpleado(cedula);
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

            Empleado epl = new Empleado();
            epl = ctlEmp.SolicitudBuscarEmpleado(cedula);
            Int32 idUsu = epl.getUsuarioId();

            Empleado emp = new Empleado(nombre,apellido,cedula,fecha,idCiudad,idSucursal,idCargo,idUsu);
            Usuario usu = new Usuario(cuenta,contraseña,idTipoUsu);
            if(ctlEmp.SolicitudModificarEmpleado( cedula,  nombre,  apellido,  fecha,
            idCiudad, idCargo, idSucursal,  cuenta,  contraseña, idUsu, idTipoUsu)){
                MessageBox.Show("Exito");
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
                if(ctlUsu.solicitudEliminarUsuario(idAux)){
                    MessageBox.Show("Eliminado correctamente");
                }
            }
        }
    }
}
