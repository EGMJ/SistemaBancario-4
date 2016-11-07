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


       public bool guardarDepartamento(Departamento dep)
       {
           String consulta = "exec guardarDepartamento '" + dep.getNombre() +
               "','" + dep.getDescripcion() + "', " + dep.getPaisId() + ";";
           return ejecutar(consulta);
       }

       public Departamento buscarDepartamento(String nombre)
       {
           Departamento entity = null;
           String consulta = "exec buscarDepartamentoNombre '" + nombre + "';";
           ejecutarRetorno(consulta);

           if (dataset.Tables[0].Rows.Count == 0)
           {
               dataset.Dispose();
           }
           else
           {
               entity = new Departamento();
               entity.setId(Convert.ToInt32(dataset.Tables[0].Rows[0]["id"].ToString()));
               entity.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
               entity.setPaisId((int)dataset.Tables[0].Rows[0]["pais_id"]);
               entity.setDescripcion(dataset.Tables[0].Rows[0]["descripcion"].ToString());
               dataset.Dispose();
           }


           return entity;
       }


       public bool modificarDepartamento(Departamento dep)
       {
           String consulta = "exec editarDepartamento '" + dep.getNombre() +
               "','" + dep.getDescripcion() + "','" + dep.getPaisId() + "';";
           return ejecutar(consulta);
       }

       public bool eliminarCiudad(int id)
       {
           String consulta = "exec borrarDepartamento " + id + ";";
           return ejecutar(consulta);
       }
    }
}
