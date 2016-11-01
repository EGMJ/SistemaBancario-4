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
        //Metodo para recibir datos y enviarlos al dao
        public bool SolicitudGuardarBanco(String nit, String nombre, String desc)
        {
            Banco banco = new Banco(nit, nombre, desc); 
            BancoDAO banDAO = new BancoDAO();
            return banDAO.guardarBanco(banco);   
        }

        public Banco SolicitudBuscarBanco(String nit)
        {
            BancoDAO banDAO = new BancoDAO();
            return banDAO.buscarBanco(nit);
        }

        public bool SolicitudModificarBanco(String nit, String nombre, String descripcion)
        {
            Banco banco = new Banco(nit, nombre, descripcion);
            BancoDAO banDAO = new BancoDAO();
            return banDAO.modificarBanco(banco);
        }

        public bool solicitudEliminarBanco(String nit)
        {
            BancoDAO banDAO = new BancoDAO();
            return banDAO.eliminarBanco(nit);
        }

    }
}
