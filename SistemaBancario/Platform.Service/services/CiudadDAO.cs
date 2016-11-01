using Platform.Object.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Service.services
{
  public  class CiudadDAO : ClsConexion
    {
        Ciudad ciudad;
        public LinkedList<Ciudad> buscarDeptoPorPais(int idDepto)
        {
            LinkedList<Ciudad> listaMpios = new LinkedList<Ciudad>();
            String consulta = "exec listarDepartamentosPorPais " + idDepto + ";";
            ejecutarRetorno(consulta);
       

            if (dataset.Tables[0].Rows.Count == 0)
            {
                dataset.Dispose();
            }
            else

                for (int j = 0; j < dataset.Tables[0].Rows.Count; j++)
                {
                    ciudad = new Departamento();

                    ciudad.setId(Convert.ToInt32(dataset.Tables[0].Rows[j]["id"].ToString()));
                    ciudad.setNombre(dataset.Tables[0].Rows[j]["nombre"].ToString());

                    listaMpios.AddFirst(ciudad);

                }
            return listaMpios;
        }
    }
}
