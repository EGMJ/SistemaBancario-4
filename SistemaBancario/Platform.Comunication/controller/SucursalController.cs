using Platform.Object.model;
using Platform.Service.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Comunication.controller
{
    public class SucursalController
    {

        SucursalDAO sucursalDAO = new SucursalDAO();
        public bool solicitudGuardar(Int32 id, String nombre, Int32 bancoId, Int32 ciudadId, Int32 gerenteId, String direccion)
        {
            Sucursal entity = new Sucursal(id, nombre, bancoId, ciudadId, gerenteId, direccion);
            return sucursalDAO.guardarSucursal(entity);

        }

        public Sucursal solicitudBuscar(String nombre)
        {
            return sucursalDAO.buscarSucursal(nombre);
        }

        public bool solicitudModificar(Int32 id, String nombre, Int32 bancoId, Int32 ciudadId, Int32 gerenteId, String direccion)
        {
            Sucursal entity = new Sucursal(id, nombre, bancoId, ciudadId, gerenteId, direccion);
            return sucursalDAO.modificarSucursal(entity);

        }

        public String solicutudEliminar(int id)
        {
            return sucursalDAO.eliminarSucursal(id);
        }
    }
}
