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


    }
}
