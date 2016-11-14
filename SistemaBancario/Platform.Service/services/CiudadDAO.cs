using Platform.Object.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Service.services
{
  public  class CiudadDAO : ClsConexion
    {
        Ciudad ciudad;
        public LinkedList<Ciudad> buscarCiudadPorDeptos(int idDepto)
        {
            LinkedList<Ciudad> listaMpios = new LinkedList<Ciudad>();
            String consulta = "exec listarMunicipiosPorDepartamento " + idDepto + ";";
            ejecutarRetorno(consulta);


            if (dataset.Tables[0].Rows.Count == 0)
            {
                dataset.Dispose();
            }
            else
                listaMpios.AddFirst(new Ciudad(-1,"Seleccione una opción"));

                for (int j = 0; j < dataset.Tables[0].Rows.Count; j++)
                {
                    ciudad = new Ciudad();

                    ciudad.setId(Convert.ToInt32(dataset.Tables[0].Rows[j]["id"].ToString()));
                    ciudad.setNombre(dataset.Tables[0].Rows[j]["nombre"].ToString());

                    listaMpios.AddLast(ciudad);

                }
            return listaMpios;
        }

        public bool guardarCiudad(Ciudad city)
        {
            String consulta = "exec guardarCiudad '" + city.getNombre() +
                "','" + city.getDescripcion() + "', " + city.getIdDepartamento() + ";";
            return ejecutar(consulta);
        }

        public Ciudad buscarCiudad(String nombre)
        {
            Ciudad ciuda = null;
            String consulta = "exec buscarCiudad '" + nombre + "';";
            ejecutarRetorno(consulta);

            if (dataset.Tables[0].Rows.Count == 0)
            {
                dataset.Dispose();
            }
            else
            {
                ciuda = new Ciudad();
                ciuda.setNombre(dataset.Tables[0].Rows[0]["nombres"].ToString());
                ciuda.setId(Convert.ToInt32(dataset.Tables[0].Rows[0]["id"].ToString()));
                
                ciuda.setIdDepartamento((int)dataset.Tables[0].Rows[0]["departamento_ids"]);
                ciuda.setDescripcion(dataset.Tables[0].Rows[0]["descripcions"].ToString());
                ciuda.idPais = Convert.ToInt32(dataset.Tables[0].Rows[0]["paisId"].ToString());
               
            }
            return ciuda;
        }


        public bool modificarCiudad(Ciudad city)
        {
            String consulta = "exec editarCiudad '" + city.getNombre() +
                "','" + city.getDescripcion() + "',"+ city.getIdDepartamento() +";";
            return ejecutar(consulta);
        }

        public bool eliminarCiudad(String nombre)
        {
            String consulta = "exec borrarCiudad '" + nombre + "';";
            return ejecutar(consulta);
        }

        public Ciudad buscarCiudadPorId(int id)
        {
            //LinkedList<Ciudad> listaMpios = new LinkedList<Ciudad>();
            String consulta = "exec buscarCiudad " + id + ";";
            ejecutarRetorno(consulta);
            if (dataset.Tables[0].Rows.Count == 0)
            {
                dataset.Dispose();
            }
            else
                //listaMpios.AddFirst(new Ciudad(-1, "Seleccione una opción"));
                ciudad = new Ciudad();
                ciudad.setId(Convert.ToInt32(dataset.Tables[0].Rows[0]["id"].ToString()));
                ciudad.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
                ciudad.setIdDepartamento(Convert.ToInt32(dataset.Tables[0].Rows[0]["departamento_id"].ToString()));
                                       
            return ciudad;

        }
    }
}
