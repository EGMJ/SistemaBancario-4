using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Object.model;
namespace Platform.Service.services
{
    public class PoliticaDAO : ClsConexion
    {

        Politica pol = new Politica();

        //Metodo para obtener la informacion de la politica
        public Politica obtenerPolitica()
        {
            Politica poli = new Politica();
            String consulta = "exec obtenerPolitica;";
            ejecutarRetorno(consulta);
            if (dataset.Tables[0].Rows.Count > 0)
            {
                poli.setMision(dataset.Tables[0].Rows[0]["mision"].ToString());
                poli.setVision(dataset.Tables[0].Rows[0]["vision"].ToString());
                dataset.Dispose();
            }
            return poli;
        }

        //Metodo para modificar la politica
        public bool modificarPolitica(Politica pol)
        {
            String consulta = "exec editarPolitica '" + pol.getMision() +
                "','" + pol.getVision() + "';";
            return ejecutar(consulta);
        }  
    }
}
