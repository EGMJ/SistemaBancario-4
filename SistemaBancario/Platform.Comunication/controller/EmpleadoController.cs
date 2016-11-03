﻿using Platform.Object.model;
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
            Int32 ciudadNacimiento, Int32 sucursalId, Int32 cargoId)
       {
           Empleado emp = new Empleado(nombre,apellido,cedula,fechaNacimiento,ciudadNacimiento,sucursalId,cargoId);
           return empDAO.guardarEmpleado(emp);
       }

       //public Cargo SolicitudBuscarEmpleado(String cedula)
       //{
       //    return empDAO.buscarEmpleado(cedula);
       //}

       //public bool SolicitudModificarCargo(String nombre, double salario, int cantidad, String desc)
       //{
       //    Cargo cargo = new Cargo(nombre, salario, cantidad, desc);
       //    return caDAO.modificarCargo(cargo);
       //}

       //public bool solicitudEliminarCargo(String nombre)
       //{
       //    return caDAO.eliminarCargo(nombre);
       //}
    }
}