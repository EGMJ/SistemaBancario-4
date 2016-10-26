using Platform.Object.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Service.services
{
    class LoginDAO : ClsConexion 
    {
        Usuario usuario = new Usuario();

        public Usuario loginUsuario(String cuenta, String clave )
        {
         String consulta = "exec buscarUsuario '"+cuenta+"' , '"+ clave+"';";
            ejecutarRetorno(consulta);
             if (dataset.Tables[0].Rows.Count == 0)
            {
                dataset.Dispose();                
            }
            else
            {
            // usuario. = dataset.Tables[0].Rows[0]["cuenta"].ToString();
             
             }
            return  usuario;
        }
    }
}
