using Platform.Object.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Service.services
{
  public  class PaisDAO : ClsConexion
    {
      Pais pais;
      public Pais buscarPaisPorId(int id)
      {
          //LinkedList<Ciudad> listaMpios = new LinkedList<Ciudad>();
          String consulta = "exec buscarCiudad " + id + ";";
          ejecutarRetorno(consulta);
          if (dataset.Tables[0].Rows.Count == 0)
          {
              dataset.Dispose();
          }
          else
              //listaMpios.AddFirst(new Ciudad(-1, "Seleccione una opción"));
          pais = new Pais();
          pais.setId(Convert.ToInt32(dataset.Tables[0].Rows[0]["id"].ToString()));
          pais.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
         // pais.setIdDepartamento(Convert.ToInt32(dataset.Tables[0].Rows[0]["departamento_id"].ToString()));

          return pais;

      }
    }
}
