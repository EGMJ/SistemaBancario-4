using Platform.Object.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Service.services
{
   public class DepartamentoDAO : ClsConexion 
    {
       Departamento depto ;
       public LinkedList<Departamento> buscarDeptoPorPais(int idPais)
       {
           LinkedList<Departamento> listaDeptos = new LinkedList<Departamento>();
           String consulta = "exec listarDepartamentosPorPais " + idPais + ";";
           ejecutarRetorno(consulta);
           if (dataset.Tables[0].Rows.Count == 0)
           {
               dataset.Dispose();
           }
           else
               listaDeptos.AddFirst(new Departamento(-1,"Seleccione una opción"));
               
                   for (int j = 0; j < dataset.Tables[0].Rows.Count;j++ )
                   {
                       depto = new Departamento();
                       
                       depto.setId(Convert.ToInt32(dataset.Tables[0].Rows[j]["id"].ToString()));
                       depto.setNombre(dataset.Tables[0].Rows[j]["nombre"].ToString());
                      
                       listaDeptos.AddLast(depto);
                   
               }
           return listaDeptos;
       }

       public Departamento buscarDepartamentoPorId(int id)
       {
           //LinkedList<Ciudad> listaMpios = new LinkedList<Ciudad>();
           String consulta = "exec buscarDepartamento " + id + ";";
           ejecutarRetorno(consulta);
           if (dataset.Tables[0].Rows.Count == 0)
           {
               dataset.Dispose();
           }
           else
               //listaMpios.AddFirst(new Ciudad(-1, "Seleccione una opción"));
           depto = new Departamento();
           depto.setId(Convert.ToInt32(dataset.Tables[0].Rows[0]["id"].ToString()));
           depto.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
           depto.setPaisId(Convert.ToInt32(dataset.Tables[0].Rows[0]["pais_id"].ToString()));

           return depto;

       }
    }
}
