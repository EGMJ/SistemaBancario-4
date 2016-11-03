using Platform.Object.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Service.services
{
    public class SucursalDAO : ClsConexion
    {

        public bool guardarSucursal(Sucursal entity)
        {
            String consulta = "exec guardarSucursal "
                + entity.getId() + ",'" + entity.getNombre()
                + "'," + entity.getBancoId() + "," + entity.getCiudadId()
                + "," + entity.getGerenteId() + ",'" + entity.getDireccion() + "';";
            return ejecutarRetorno(consulta);
            //String info = dataset.Tables[0].Rows[0].ToString();

            //return info;
        }

        public Sucursal buscarSucursal(String entity)
        {
            Sucursal sucursal = new Sucursal();
            String consulta = "exec buscarSucursal '" + entity + "';";
            ejecutarRetorno(consulta);
            if (dataset != null)
            {
                sucursal.setId(Convert.ToInt32(dataset.Tables[0].Rows[0]["id"].ToString()));
                sucursal.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
              // String i = dataset.Tables[0].Rows[0]["gerenteId"].ToString();
                sucursal.setGerenteId(Convert.ToInt32(dataset.Tables[0].Rows[0]["gerenteId"].ToString()));
                sucursal.setDireccion(dataset.Tables[0].Rows[0]["direccion"].ToString());
                sucursal.setCiudadId(Convert.ToInt32(dataset.Tables[0].Rows[0]["ciudad_id"].ToString()));
                sucursal.setBancoId(Convert.ToInt32(dataset.Tables[0].Rows[0]["banco_id"].ToString()));
                sucursal.idDepartamento = Convert.ToInt32(dataset.Tables[0].Rows[0]["idDepto"].ToString());
                sucursal.idPais = Convert.ToInt32(dataset.Tables[0].Rows[0]["idPais"].ToString());
                
            }
            else
            {
               // dataset.Dispose();
                sucursal = null;
            }

                
            return sucursal;


        }

        public bool modificarSucursal(Sucursal entity)
        {
            String consulta = "exec guardarSucursal "
                + entity.getId() + ",'" + entity.getNombre()
                + "'," + entity.getBancoId() + "," + entity.getCiudadId()
                + "," + entity.getGerenteId() + ",'" + entity.getDireccion() + "';";
            return ejecutarRetorno(consulta);
            
        }
    }
}
