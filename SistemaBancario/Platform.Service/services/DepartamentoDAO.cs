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
           int D = dataset.Tables[0].Columns.Count;

           if (dataset.Tables[0].Rows.Count == 0)
           {
               dataset.Dispose();
           }
           else
               
                   for (int j = 0; j < dataset.Tables[0].Rows.Count;j++ )
                   {
                       depto = new Departamento();
                       
                       depto.setId(Convert.ToInt32(dataset.Tables[0].Rows[j]["id"].ToString()));
                       depto.setNombre(dataset.Tables[0].Rows[j]["nombre"].ToString());
                      
                       listaDeptos.AddFirst(depto);
                   
               }
           return listaDeptos;
       }
    }
}
