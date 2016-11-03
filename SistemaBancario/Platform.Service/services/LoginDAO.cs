using Platform.Object.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Service.services
{
    public class LoginDAO : ClsConexion 
    {
        Usuario usuario = new Usuario();

        public LoginDAO()
        {
            
        }

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
                usuario.setId(Convert.ToInt32(dataset.Tables[0].Rows[0]["id"].ToString()));
                usuario.setClave(dataset.Tables[0].Rows[0]["clave"].ToString());
                usuario.setCuenta(dataset.Tables[0].Rows[0]["cuenta"].ToString());
                usuario.setTipoUsuario(Convert.ToInt32(dataset.Tables[0].Rows[0]["tipo_usuario_id"].ToString()));
             
             }
            return  usuario;
        }
    }
}
