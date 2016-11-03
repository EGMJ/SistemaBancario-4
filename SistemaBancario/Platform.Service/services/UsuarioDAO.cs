using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Object.model;
namespace Platform.Service.services
{
    public class UsuarioDAO : ClsConexion
    {

        public bool guardarUsuario(Usuario usu)
        {
            String consulta = "exec guardarUsuario '" + usu.getCuenta() +
                "','" + usu.getClave() + "', " + usu.getTipoUsuario() + ";";
            return ejecutar(consulta);
        }

        public Usuario obtenerIdUsu(String cuenta)
        {
            Usuario usu = new Usuario();
            String consulta = "exec obtenerIdUsuario '" + cuenta + "';";
            ejecutarRetorno(consulta);

            if (dataset.Tables[0].Rows.Count == 0)
            {
                dataset.Dispose();
            }
            else
            {
                usu.setId((int)dataset.Tables[0].Rows[0]["id"]);
                usu.setCuenta(dataset.Tables[0].Rows[0]["cuenta"].ToString());
                usu.setClave(dataset.Tables[0].Rows[0]["clave"].ToString());
                usu.setTipoUsuario((int)dataset.Tables[0].Rows[0]["tipo_usuario_id"]);
                dataset.Dispose();
            }


            return usu;
        }

    }
}
