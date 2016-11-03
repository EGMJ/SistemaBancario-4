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
              emp.getCargoId() + ","+ emp.getSucursalId() + "," + emp.getUsuarioId() +";";
          return ejecutar(consulta);
      }

      public Empleado buscarEmpleado(String cedula)
      {
          Empleado emple = new Empleado();
          String consulta = "exec buscarEmpleado '" + cedula + "';";
          ejecutarRetorno(consulta);

          if (dataset.Tables[0].Rows.Count == 0)
          {
              dataset.Dispose();
          }
          else
          {
              emple.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
              emple.setApellido(dataset.Tables[0].Rows[0]["apellido"].ToString());
              emple.setFechaNacimiento(dataset.Tables[0].Rows[0]["fecha_nacimiento"].ToString());
              emple.setCargoId((int)dataset.Tables[0].Rows[0]["cargo_id"]);
              emple.setCiudadNacimiento((int)dataset.Tables[0].Rows[0]["ciudad_id"]);
              emple.setSucursalId((int)dataset.Tables[0].Rows[0]["sucursal_id"]);
              emple.setUsuarioId((int)dataset.Tables[0].Rows[0]["idUsuario"]);
              dataset.Dispose();
          }


          return emple;
      }


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
