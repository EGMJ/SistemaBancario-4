using Platform.Object.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Service.services
{
    public class TipoCuentaDAO : ClsConexion
    {

        public TipoCuenta buscarTipoCuenta(String nombre)
        {
            TipoCuenta entity = null;
            String consulta = "exec buscarTipoCuenta '" + nombre + "';";
            ejecutarRetorno(consulta);
            if (dataset.Tables[0].Rows.Count == 0)
            {
                dataset.Dispose();
            }
            else
            {
                entity = new TipoCuenta();
                entity.setId(Convert.ToInt32(dataset.Tables[0].Rows[0]["id"].ToString()));
                entity.setDescripcion(dataset.Tables[0].Rows[0]["nombre"].ToString());
                // String i = dataset.Tables[0].Rows[0]["gerenteId"].ToString();
                entity.setDescripcion(dataset.Tables[0].Rows[0]["descripcion"].ToString());

            }

            return entity;
        }

        public String guardarTipoCuenta(TipoCuenta entity)
        {
            String consulta = "exec guardarTipoCuenta "
                + entity.getId() + ",'" + entity.getNombre()
                + "','"  + entity.getDescripcion() + "';";
            ejecutarRetorno(consulta);
            String info = dataset.Tables[0].Rows[0]["respuesta"].ToString();
            return info;
        }
    }
}
