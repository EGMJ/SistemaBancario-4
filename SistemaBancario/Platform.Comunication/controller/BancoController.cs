using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Platform.Object.model;
using Platform.Service.services;
namespace Platform.Comunication.controller
{
    class BancoController
    {
        //Metodo para recibir datos y enviarlos al dao
        public bool SolicitudGuardarBanco(String nit, String nombre, String desc)
        {
            Banco banco = new Banco(nit, nombre, desc); 
            BancoDAO banDAO = new BancoDAO();
            return banDAO.guardarBanco(banco);   
        }

    }
}
