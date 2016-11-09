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

        public String guardarSucursal(Sucursal entity)
        {
            String consulta = "exec guardarSucursal "
                + entity.getId() + ",'" + entity.getNombre()
                + "'," + entity.getBancoId() + "," + entity.getCiudadId()
                + "," + entity.getGerenteId() + ",'" + entity.getDireccion() + "';";
             ejecutarRetorno(consulta);
            String info = dataset.Tables[0].Rows[0]["respuesta"].ToString();

            return info;
        }

        public Sucursal buscarSucursal(String nombre)
        {
            Sucursal entity = null;
            String consulta = "exec buscarSucursal '" + nombre + "';";
            ejecutarRetorno(consulta);
            if (dataset.Tables[0].Rows.Count == 0)
            {
                dataset.Dispose();
            }
            else
            {
                entity= new Sucursal();
                entity.setId(Convert.ToInt32(dataset.Tables[0].Rows[0]["id"].ToString()));
                entity.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
                // String i = dataset.Tables[0].Rows[0]["gerenteId"].ToString();
                entity.setGerenteId(Convert.ToInt32(dataset.Tables[0].Rows[0]["gerenteId"].ToString()));
                entity.setDireccion(dataset.Tables[0].Rows[0]["direccion"].ToString());
                entity.setCiudadId(Convert.ToInt32(dataset.Tables[0].Rows[0]["ciudad_id"].ToString()));
                entity.setBancoId(Convert.ToInt32(dataset.Tables[0].Rows[0]["banco_id"].ToString()));
                entity.idDepartamento = Convert.ToInt32(dataset.Tables[0].Rows[0]["idDepto"].ToString());
                entity.idPais = Convert.ToInt32(dataset.Tables[0].Rows[0]["idPais"].ToString());
            }
                         
            return entity;


        }


        public String eliminarSucursal(int id)
        {String info= null;
            try
            {
                String consulta = "exec borrarSucursal " + id + ";";
                ejecutarRetorno(consulta);
                info = dataset.Tables[0].Rows[0]["respuesta"].ToString();
            }catch(Exception e){
                return info;
            }
            
            return info;
        }
    }

}
