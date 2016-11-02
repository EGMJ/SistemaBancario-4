using Platform.Object.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Service.services
{
  public class EmpleadoDao : ClsConexion
    {
      Empleado empleado;
      public LinkedList<Empleado> obtenerGerente()
      {
          LinkedList<Empleado> listaDeptos = new LinkedList<Empleado>();
          String consulta = "exec obtenerGerentes;";
          ejecutarRetorno(consulta);
          if (dataset.Tables[0].Rows.Count == 0)
          {
              dataset.Dispose();
          }
          else

              for (int j = 0; j < dataset.Tables[0].Rows.Count; j++)
              {
                  empleado = new Empleado();

                  empleado.setId(Convert.ToInt32(dataset.Tables[0].Rows[j]["id"].ToString()));
                  empleado.setNombre(dataset.Tables[0].Rows[j]["nombre"].ToString());

                  listaDeptos.AddFirst(empleado);

              }
          return listaDeptos;
      }
    }
}
