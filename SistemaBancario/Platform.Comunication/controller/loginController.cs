using Platform.Object.model;
using Platform.Service.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Platform.Comunication.controller
{
    public class LoginController
    {
        private Int32 idTipo;

        public bool solicitudLogin(String cuenta, String clave)
        {
            LoginDAO loginDao = new LoginDAO();
            Usuario usuario = loginDao.loginUsuario(cuenta,clave);
            if (usuario !=null){
              idTipo= usuario.getTipoUsuario();
              return true;
           }
            return false;
             
        }

       

        public Int32 getIdTipo()
        {
            return this.idTipo;
        }

        public void setIdTipo(Int32 idTipo)
        {
            this.idTipo = idTipo;
        }
    }
}
