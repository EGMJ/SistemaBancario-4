using Platform.Object.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Service.services
{
    public class JuntaDirectivaDAO : ClsConexion
    {

        public MiembroJuntaDirectiva buscarJunta(String cedula)
        {
            MiembroJuntaDirectiva entity = null;
            String consulta = "exec buscarJunta '" + cedula + "';";
            ejecutarRetorno(consulta);
            if (dataset.Tables[0].Rows.Count == 0)
            {
                dataset.Dispose();
            }
            else
            {
                entity = new MiembroJuntaDirectiva();
                entity.setId(Convert.ToInt32(dataset.Tables[0].Rows[0]["id"].ToString()));
                entity.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
                entity.setApellido(dataset.Tables[0].Rows[0]["apellido"].ToString());
                entity.setCedula(dataset.Tables[0].Rows[0]["cedula"].ToString());
                entity.setBancoId(Convert.ToInt32(dataset.Tables[0].Rows[0]["bancoId"].ToString()));
                entity.setAcciones(Convert.ToDouble(dataset.Tables[0].Rows[0]["acciones"].ToString()));
                entity.setCiudadNacimiento(Convert.ToInt32(dataset.Tables[0].Rows[0]["ciudad_id"].ToString()));
                entity.setFechaNacimiento(dataset.Tables[0].Rows[0]["fecha"].ToString());
                entity.idDepartamento = Convert.ToInt32(dataset.Tables[0].Rows[0]["idDepto"].ToString());
                entity.idPais = Convert.ToInt32(dataset.Tables[0].Rows[0]["idPais"].ToString());
            }

            return entity;
        }

        public String guardarJunta(MiembroJuntaDirectiva entity)
        {
            String consulta = "exec guardarJunta "
                + entity.getId() + ",'" + entity.getCedula()+ "','" + entity.getNombre() + "','"+
                entity.getApellido()+"',"+entity.getAcciones()+",'"+entity.getFechaNacimiento()+"',"+entity.getCiudadNacimiento()
                +","+entity.getBancoId()+";";
            ejecutarRetorno(consulta);
            String info = dataset.Tables[0].Rows[0]["respuesta"].ToString();
            return info;
        }

      

        public string eliminarJunta(int id)
        {
            String consulta = "exec borrarJunta " + id + ";";
            ejecutarRetorno(consulta);
            String info = dataset.Tables[0].Rows[0]["respuesta"].ToString();
            return info;
        }
    }
}
