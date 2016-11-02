﻿using Platform.Object.model;
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

                for (int j = 0; j < dataset.Tables[0].Rows.Count; j++)
                {
                    ciudad = new Ciudad();

                    ciudad.setId(Convert.ToInt32(dataset.Tables[0].Rows[j]["id"].ToString()));
                    ciudad.setNombre(dataset.Tables[0].Rows[j]["nombre"].ToString());

                    listaMpios.AddFirst(ciudad);

                }
            return listaMpios;
        }

        public bool guardarCiudad(Ciudad city)
        {
            String consulta = "exec guardarCiudad '" + city.getNombre() +
                "','" + city.getDescripcion() + "';'";
            return ejecutar(consulta);
        }

        public Ciudad buscarCiudad(String nombre)
        {
            Ciudad ciuda = new Ciudad();
            String consulta = "exec buscarCiudad '" + nombre + "';";
            ejecutarRetorno(consulta);

            if (dataset.Tables[0].Rows.Count == 0)
            {
                dataset.Dispose();
            }
            else
            {
                ciuda.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
                ciuda.setDescripcion(dataset.Tables[0].Rows[0]["descripcion"].ToString());
                dataset.Dispose();
            }


            return ciuda;
        }


        public bool modificarCiudad(Ciudad city)
        {
            String consulta = "exec editarCiudad '" + city.getNombre() +
                "','" + city.getDescripcion() + "','"+ city.getIdDepartamento() +"';";
            return ejecutar(consulta);
        }

        public bool eliminarCiudad(String nombre)
        {
            String consulta = "exec borrarCiudad '" + nombre + "';";
            return ejecutar(consulta);
        }
    }
}
