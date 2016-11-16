using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Object.model;
namespace Platform.Service.services
{
    public class TipoCuentaCostoDAO : ClsConexion
    {

        public bool guardarCuentaCosto(TipoCuentaCosto cuentaCos)
        {
            String consulta = "exec guardarCuentaCosto " + cuentaCos.getTipoCuentaId() +
                "," + cuentaCos.getCostoId() + ";" ;
            return ejecutar(consulta);
        }

        public TipoCuentaCosto buscarCuentaCosto(Int32 cuentaId)
        {
            TipoCuentaCosto tcc = null;
            String consulta = "exec buscarCuentaCosto " + cuentaId + ";";
            ejecutarRetorno(consulta);

            if (dataset.Tables[0].Rows.Count == 0)
            {
                dataset.Dispose();
            }
            else
            {
                tcc = new TipoCuentaCosto();
                tcc.setId((int)dataset.Tables[0].Rows[0]["id"]);
                tcc.setTipoCuentaId((int)dataset.Tables[0].Rows[0]["tipo_cuenta_id"]);
                tcc.setCostoId((int)dataset.Tables[0].Rows[0]["costo_id"]);
                dataset.Dispose();
            }
            return tcc;
        }


        public bool modificarCuentaCosto(TipoCuentaCosto tcc)
        {
            String consulta = "exec editarCuentaCosto " + tcc.getId() + ","+ tcc.getTipoCuentaId() +
                "," + tcc.getCostoId() + ";";
            return ejecutar(consulta);
        }

        public bool eliminarCuentaCosto(Int32 id)
        {
            String consulta = "exec borrarCuentaCosto " + id + ";";
            return ejecutar(consulta);
        }

    }
}
