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
              emple.setCargoId((int)dataset.Tables[0].Rows[0]["cargo"]);
              emple.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
              emple.setApellido(dataset.Tables[0].Rows[0]["apellido"].ToString());
              emple.setFechaNacimiento(dataset.Tables[0].Rows[0]["fechaNa"].ToString());              
              emple.setCiudadNacimiento((int)dataset.Tables[0].Rows[0]["ciudad"]);
              emple.setSucursalId((int)dataset.Tables[0].Rows[0]["sucursal"]);              
              emple.cuenta = (dataset.Tables[0].Rows[0]["cuenta"].ToString());              
              emple.nombreTipoUsu = ((int)dataset.Tables[0].Rows[0]["nombreTipoUsu"]);
              emple.setUsuarioId((int)dataset.Tables[0].Rows[0]["usu"]);
              dataset.Dispose();
          }


          return emple;
      }


      public bool modificarEmpleado(Empleado empl, Usuario usu)
      {
          String consulta = "exec editarEmpleado '" + empl.getCedula() +
              "','" + empl.getNombre() + "','" + empl.getApellido()+ "','"+
              empl.getFechaNacimiento() +"',"+ empl.getCargoId() + ","+
              empl.getCiudadNacimiento() +","+ empl.getSucursalId() +",'"+
              usu.getCuenta() + "','" + usu.getClave() + "'," + usu.getTipoUsuario() + "," +
              empl.getUsuarioId()+";";
          return ejecutar(consulta);
      }

      public bool eliminarEmpleado(String cedula)
      {
          String consulta = "exec borrarEmpleado '" + cedula + "';";
          return ejecutar(consulta);
      }


    }
}
