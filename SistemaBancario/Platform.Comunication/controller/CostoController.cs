using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Object.model;
using Platform.Service.services;
namespace Platform.Comunication.controller
{
    public class CostoController
    {

        CostoDAO cosDAO = new CostoDAO();

        public bool SolicitudGuardarCosto(String nombre, double monto)
        {
            Costo cos = new Costo(nombre, monto);
            return cosDAO.guardarCosto(cos);
        }

        public Costo SolicitudBuscarCosto(String nombre)
        {
            return cosDAO.buscarCosto(nombre);
        }

        public bool SolicitudModificarCosto(String nombre, float monto)
        {
            Costo cos = new Costo(nombre, monto);
            return cosDAO.modificarCosto(cos);
        }

        public bool solicitudEliminarPais(int id)
        {
            return cosDAO.eliminarCosto(id);
        }
    }
}
