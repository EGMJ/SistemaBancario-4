using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Platform.Object.model;
using Platform.Service.services;
namespace Platform.Comunication.controller
{
    public class PoliticaController
    {

        PoliticaDAO polDAO = new PoliticaDAO();

        public Politica solicitudObtenerPolitica()
        {
            Politica p = polDAO.obtenerPolitica();
            return p;
        }

        public bool SolicitudModificarBanco(String mision, String vision)
        {
            Politica pol = new Politica(mision,vision);
            return polDAO.modificarPolitica(pol);
        }

    }
}
