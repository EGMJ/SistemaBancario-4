using Platform.Object.model;
using Platform.Service.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Comunication.controller
{
    public class CiudadController
    {

        CiudadDAO ciudadDAO = new CiudadDAO();

        public LinkedList<Ciudad> solicitudListaCiudadPorDeptos(int idDepto)
        {            
            return ciudadDAO.buscarCiudadPorDeptos(idDepto);
        }

        public bool SolicitudGuardarCiudad(String nombre, String desc, Int32 deptoId)
        {
            Ciudad city = new Ciudad(nombre, desc, deptoId);
            return ciudadDAO.guardarCiudad(city);
        }

        public Ciudad SolicitudBuscarCiudad(String nombre)
        {
            return ciudadDAO.buscarCiudad(nombre);
        }

        public bool SolicitudModificarCiudad(String nombre, String descripcion,Int32 deptoId)
        {
            Ciudad city = new Ciudad(nombre, descripcion, deptoId);
            return ciudadDAO.modificarCiudad(city);
        }

        public bool solicitudEliminarCiudad(String nombre)
        {
            return ciudadDAO.eliminarCiudad(nombre);
        }
    }
}
