using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Object.model;
using Platform.Service.services;
namespace Platform.Comunication.controller
{
    public class UsuarioController
    {

        UsuarioDAO usuDAO = new UsuarioDAO();

        public bool SolicitudGuardarUsuario(String cuenta, String clave, Int32 idTipoUsu)
        {
            Usuario usu = new Usuario(cuenta,clave,idTipoUsu);
            return usuDAO.guardarUsuario(usu);
        }

        public Usuario SolicitudObtenerIdUsuario(String cuenta)
        {
            return usuDAO.obtenerIdUsu(cuenta);
        }

        public bool solicitudEliminarUsuario(Int32 id)
        {
            return usuDAO.eliminarUsuario(id);
        }

    }
}
