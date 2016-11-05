using Platform.Object.model;
using Platform.Service.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Comunication.controller
{
    public class PaisController
    {

        PaisDAO paisDao = new PaisDAO();

        public Pais solicitudBuscarPorId(int id)
        {
            return paisDao.buscarPaisPorId(id);
        }


        public bool SolicitudGuardarPais(String nombre, String desc)
        {
            Pais pais = new Pais(nombre, desc);
            return paisDao.guardarPais(pais);
        }

        public Pais SolicitudBuscarPais(String nombre)
        {
            return paisDao.buscarPais(nombre);
        }

        public bool SolicitudModificarPais(String nombre, String descripcion)
        {
            Pais pais = new Pais(nombre, descripcion);
            return paisDao.modificarPais(pais);
        }

        public bool solicitudEliminarPais(String nombre)
        {
            return paisDao.eliminarPais(nombre);
        }
    }
}
