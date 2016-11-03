using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Object.model;
namespace Platform.Service.services
{
    public class CargoDAO : ClsConexion
    {

        public bool guardarCargo(Cargo cargo)
        {
            String consulta = "exec guardarCargo '" + cargo.getNombre() +
                "'," + cargo.getSalario() + "," + cargo.getCantidadHoras() + 
                ",'" + cargo.getDescripcion() + "';";
            return ejecutar(consulta);
        }

        public Cargo buscarCargo(String nombre)
        {
            Cargo ca = new Cargo();
            String consulta = "exec buscarCargo '" + nombre + "';";
            ejecutarRetorno(consulta);

            if (dataset.Tables[0].Rows.Count == 0)
            {
                dataset.Dispose();
            }
            else
            {
                ca.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
                ca.setSalario((double)dataset.Tables[0].Rows[0]["salario"]);
                ca.setCantidadHoras((int)dataset.Tables[0].Rows[0]["cantidad_horas"]);
                ca.setDescripcion(dataset.Tables[0].Rows[0]["descripcion"].ToString());
                dataset.Dispose();
            }
            return ca;
        }


        public bool modificarCargo(Cargo cargo)
        {
            String consulta = "exec editarCargo '" + cargo.getNombre() +
                "'," + cargo.getSalario() + "," + cargo.getCantidadHoras() +
                ",'"+ cargo.getDescripcion() +"';";
            return ejecutar(consulta);
        }

        public bool eliminarCargo(String nombre)
        {
            String consulta = "exec borrarCargo '" + nombre + "';";
            return ejecutar(consulta);
        }
       

    }
}
