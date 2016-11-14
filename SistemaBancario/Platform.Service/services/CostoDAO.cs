using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Object.model;
namespace Platform.Service.services
{
    public class CostoDAO : ClsConexion
    {

        Costo costo;

         public bool guardarCosto(Costo costo)
       {
           String consulta = "exec guardarCosto '" + costo.getNombre() +
               "'," + costo.getMonto() + ";";
           return ejecutar(consulta);
       }

       public Costo buscarCosto(String nombre)
       {
           Costo entity = null;
           String consulta = "exec buscarCostoNombre '" + nombre + "';";
           ejecutarRetorno(consulta);

           if (dataset.Tables[0].Rows.Count == 0)
           {
               dataset.Dispose();
           }
           else
           {
               entity = new Costo();
               entity.setId(Convert.ToInt32(dataset.Tables[0].Rows[0]["id"].ToString()));
               entity.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
               entity.setMonto((double)dataset.Tables[0].Rows[0]["monto"]);
               dataset.Dispose();
           }

           return entity;
       }


       public bool modificarCosto(Costo cos)
       {
           String consulta = "exec editarCosto '" + costo.getNombre() +
               "'," + costo.getMonto() + ";";
           return ejecutar(consulta);
       }

       public bool eliminarCosto(int id)
       {
           String consulta = "exec borrarCosto" + id + ";";
           return ejecutar(consulta);
       }
    

    }
}
