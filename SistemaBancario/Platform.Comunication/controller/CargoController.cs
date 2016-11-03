using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Object.model;
using Platform.Service.services;
namespace Platform.Comunication.controller
{
    public class CargoController
    {

        CargoDAO caDAO = new CargoDAO();

        public bool SolicitudGuardarCargo(String nombre, double salario, Int32 cantidad , String desc)
        {
            Cargo cargo = new Cargo(nombre,  salario,  cantidad ,  desc);
            return caDAO.guardarCargo(cargo);
        }

        public Cargo SolicitudBuscarCargo(String nombre)
        {
            return caDAO.buscarCargo(nombre);
        }

        public bool SolicitudModificarCargo(String nombre, double salario, int cantidad, String desc)
        {
            Cargo cargo = new Cargo(nombre, salario, cantidad, desc);
            return caDAO.modificarCargo(cargo);
        }

        public bool solicitudEliminarCargo(String nombre)
        {
            return caDAO.eliminarCargo(nombre);
        }

    }
}
