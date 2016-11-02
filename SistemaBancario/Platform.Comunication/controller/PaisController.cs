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
    }
}
