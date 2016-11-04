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

       //public bool SolicitudModificarCargo(String nombre, double salario, int cantidad, String desc)
       //{
       //    Cargo cargo = new Cargo(nombre, salario, cantidad, desc);
       //    return caDAO.modificarCargo(cargo);
       //}

       public bool solicitudEliminarEmpleado(String cedula)
       {
           return empDAO.eliminarEmpleado(cedula);
       }
    }
}
