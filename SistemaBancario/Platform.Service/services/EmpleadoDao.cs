using Platform.Object.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Service.services
{
  public class EmpleadoDao : ClsConexion
    {
      Empleado empleado;
      public LinkedList<Empleado> obtenerGerente()
      {
          LinkedList<Empleado> listaGerentes = new LinkedList<Empleado>();
          String consulta = "exec obtenerGerentes;";
          ejecutarRetorno(consulta);
          if (dataset.Tables[0].Rows.Count == 0)
          {
              dataset.Dispose();
          }
          else

              listaGerentes.AddFirst(new Empleado(-1, "Seleccione una opción"));
              for (int j = 0; j < dataset.Tables[0].Rows.Count; j++)
              {
                  empleado = new Empleado();

                  empleado.setId(Convert.ToInt32(dataset.Tables[0].Rows[j]["id"].ToString()));
                  empleado.setNombre(dataset.Tables[0].Rows[j]["nombre"].ToString());

                  listaGerentes.AddLast(empleado);

              }
          return listaGerentes;
      }

      public bool guardarEmpleado(Empleado emp)
      {
          String consulta = "exec guardarEmpleado '" + emp.getCedula() +
              "','" + emp.getNombre() + "','" + emp.getApellido() + "','" +
              emp.getFechaNacimiento() + "'," + emp.getCiudadNacimiento() +","+
              emp.getCargoId() + ";";
          return ejecutar(consulta);
      }

      //public Empleado buscarEmpleado(String cedula)
      //{
      //    Empleado empleado = new Empleado();
      //    String consulta = "exec buscarEmpleado '" + cedula + "';";
      //    ejecutarRetorno(consulta);

      //    if (dataset.Tables[0].Rows.Count == 0)
      //    {
      //        dataset.Dispose();
      //    }
      //    else
      //    {
      //        emple.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
      //        ciuda.setIdDepartamento((int)dataset.Tables[0].Rows[0]["departamento_id"]);
      //        ciuda.setDescripcion(dataset.Tables[0].Rows[0]["descripcion"].ToString());
      //        dataset.Dispose();
      //    }


      //    return empleado;
      //}


      public bool modificarCiudad(Ciudad city)
      {
          String consulta = "exec editarCiudad '" + city.getNombre() +
              "','" + city.getDescripcion() + "','" + city.getIdDepartamento() + "';";
          return ejecutar(consulta);
      }

      public bool eliminarCiudad(String nombre)
      {
          String consulta = "exec borrarCiudad '" + nombre + "';";
          return ejecutar(consulta);
      }


    }
}
