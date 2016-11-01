using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Object.model;

namespace Platform.Service.services
{
   public class BancoDAO : ClsConexion 
    {

       Banco banco = new Banco();

       public bool guardarBanco(Banco banc)
       {
           String consulta = "exec guardarBanco '"+ banc.getNit() + 
               "','" + banc.getNombre() + "','" + banc.getDescripcion() + "';";               
           return ejecutar(consulta);
       }

       public Banco buscarBanco(String nit)
       {
           String consulta = "exec buscarBanco '" + nit + "';";
           ejecutarRetorno(consulta);

           if (dataset.Tables[0].Rows.Count == 0)
           {
               dataset.Dispose();
           }
           else
           {
               banco.setNit(dataset.Tables[0].Rows[0]["nit"].ToString());
               banco.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
               banco.setDescripcion(dataset.Tables[0].Rows[0]["descripcion"].ToString());               
               dataset.Dispose();
           }


           return banco;
       }


       public bool modificarBanco(Banco banco)
       {
           String consulta = "exec editarBanco '" + banco.getNit() +
               "','" + banco.getNombre() + "','" + banco.getDescripcion() + "';";
           return ejecutar(consulta);
       }

       public bool eliminarBanco(String nit)
       {
           String consulta = "exec borrarBanco '" + nit + "';";
           return ejecutar(consulta);
       }


    }
}
