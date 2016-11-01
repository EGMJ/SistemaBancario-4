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
        public LinkedList<Ciudad> solicitudListaCiudadPorDeptos(int idDepto)
        {
            CiudadDAO ciudadDAO = new CiudadDAO();
            return ciudadDAO.buscarCiudadPorDeptos(idDepto);

        }
    }
}
