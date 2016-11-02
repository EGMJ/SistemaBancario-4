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

       //Metodo para obtener la informacion del banco
       public Banco obtenerBanco()
       {
           Banco banc = new Banco();
           String consulta = "exec obtenerBanco;";
           ejecutarRetorno(consulta);
           if (dataset.Tables[0].Rows.Count > 0)
           {
               banc.setId(Convert.ToInt32(dataset.Tables[0].Rows[0]["id"].ToString()));
               banc.setNit(dataset.Tables[0].Rows[0]["nit"].ToString());
               banc.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
               banc.setDescripcion(dataset.Tables[0].Rows[0]["descripcion"].ToString());
               dataset.Dispose();
           }           
           return banc;
       }

       //Metodo para modificar al banco
       public bool modificarBanco(Banco banco)
       {
           String consulta = "exec editarBanco '" + banco.getNit() +
               "','" + banco.getNombre() + "','" + banco.getDescripcion() + "';";
           return ejecutar(consulta);
       }    




    }
}
