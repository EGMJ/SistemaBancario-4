using Platform.Object.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Service.services
{
    public class PaisDAO : ClsConexion
    {
        Pais pais;
        public Pais buscarPaisPorId(int id)
        {
            //LinkedList<Ciudad> listaMpios = new LinkedList<Ciudad>();
            String consulta = "exec buscarPais " + id + ";";
            ejecutarRetorno(consulta);
            if (dataset.Tables[0].Rows.Count == 0)
            {
                dataset.Dispose();
            }
            else
            {
                pais = new Pais();
                pais.setId(Convert.ToInt32(dataset.Tables[0].Rows[0]["id"].ToString()));
                pais.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
            }
            //listaMpios.AddFirst(new Ciudad(-1, "Seleccione una opción"));
            // pais.setIdDepartamento(Convert.ToInt32(dataset.Tables[0].Rows[0]["departamento_id"].ToString()));

            return pais;

        }

        public bool guardarPais(Pais pais)
        {
            String consulta = "exec guardarPais '" + pais.getNombre() +
                "','" + pais.getDescripcion() + "';";
            return ejecutar(consulta);
        }

        public Pais buscarPais(String nombre)
        {
            Pais p = new Pais();
            String consulta = "exec buscarPaisNombre '" + nombre + "';";
            ejecutarRetorno(consulta);

            if (dataset.Tables[0].Rows.Count == 0)
            {
                dataset.Dispose();
            }
            else
            {
                p.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
                p.setDescripcion(dataset.Tables[0].Rows[0]["descripcion"].ToString());
                dataset.Dispose();
            }
            return p;
        }


        public bool modificarPais(Pais pais)
        {
            String consulta = "exec editarPais '" + pais.getNombre() +
                "','" + pais.getDescripcion() + "';";
            return ejecutar(consulta);
        }

        public bool eliminarPais(String nombre)
        {
            String consulta = "exec borrarPais '" + nombre + "';";
            return ejecutar(consulta);
        }
    }
}
