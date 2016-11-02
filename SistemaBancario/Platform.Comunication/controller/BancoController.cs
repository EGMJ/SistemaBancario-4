using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Platform.Object.model;
using Platform.Service.services;
namespace Platform.Comunication.controller
{
    public class BancoController
    {
        BancoDAO banDAO = new BancoDAO();

        public Banco solicitudObtenerBanco()
        {
            Banco b = banDAO.obtenerBanco();
            return b;
        }

        public bool SolicitudModificarBanco(String nit, String nombre, String descripcion)
        {
            Banco banco = new Banco(nit, nombre, descripcion);            
            return banDAO.modificarBanco(banco);
        }

    }
}
