using Platform.Object.model;
using Platform.Service.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Comunication.controller
{
   public class EmpleadoController
    {

       EmpleadoDao empDAO = new EmpleadoDao();

       public LinkedList<Empleado> solicitudObtenerGerente()
       {
           EmpleadoDao empleadoDAO = new EmpleadoDao();
           return empleadoDAO.obtenerGerente();
       }

       public bool SolicitudGuardarEmpleado(String nombre, String apellido, String cedula, String fechaNacimiento,
            Int32 ciudadNacimiento, Int32 sucursalId, Int32 cargoId, Int32 usuarioId)
       {
           Empleado emp = new Empleado(nombre,apellido,cedula,fechaNacimiento,ciudadNacimiento,sucursalId,cargoId,usuarioId);
           return empDAO.guardarEmpleado(emp);
       }

       public Empleado SolicitudBuscarEmpleado(String cedula)
       {
           return empDAO.buscarEmpleado(cedula);
       }

       public bool SolicitudModificarEmpleado(String cedula, String nombre, String apellido, String fecha,
           Int32 ciudadId,Int32 cargoId,Int32 sucursalId, String cuenta, String contraseña,
           Int32 idUsu,Int32 idTipoUsu)
       {
           Empleado empl = new Empleado(nombre, apellido, cedula, fecha,
            ciudadId, sucursalId, cargoId, idUsu);
           Usuario usu = new Usuario( cuenta,  contraseña,  idTipoUsu);
           return empDAO.modificarEmpleado(empl,usu);
       }

       public bool solicitudEliminarEmpleado(String cedula)
       {
           return empDAO.eliminarEmpleado(cedula);
       }
    }
}
