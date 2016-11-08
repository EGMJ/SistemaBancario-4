using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Object.model;
namespace Platform.Service.services
{
    public class ClienteDAO : ClsConexion
    {

        Cliente cliente;

        public bool guardarCliente(Cliente cli)
        {
            String consulta = "exec guardarCliente '" + cli.getCedula() +
                "','" + cli.getNombre() + "','" + cli.getApellido() + "','" +
                cli.getFechaNacimiento() + "',"+ cli.getIdUsuario() + ";";
            return ejecutar(consulta);
        }

        //public Empleado buscarEmpleado(String cedula)
        //{
        //    Empleado emple = new Empleado();
        //    String consulta = "exec buscarEmpleado '" + cedula + "';";
        //    ejecutarRetorno(consulta);

        //    if (dataset.Tables[0].Rows.Count == 0)
        //    {
        //        dataset.Dispose();
        //    }
        //    else
        //    {
        //        emple.setCargoId((int)dataset.Tables[0].Rows[0]["cargo"]);
        //        emple.setNombre(dataset.Tables[0].Rows[0]["nombre"].ToString());
        //        emple.setApellido(dataset.Tables[0].Rows[0]["apellido"].ToString());
        //        emple.setFechaNacimiento(dataset.Tables[0].Rows[0]["fechaNa"].ToString());
        //        emple.setCiudadNacimiento((int)dataset.Tables[0].Rows[0]["ciudad"]);
        //        emple.setSucursalId((int)dataset.Tables[0].Rows[0]["sucursal"]);
        //        emple.cuenta = (dataset.Tables[0].Rows[0]["cuenta"].ToString());
        //        emple.nombreTipoUsu = ((int)dataset.Tables[0].Rows[0]["nombreTipoUsu"]);
        //        emple.setUsuarioId((int)dataset.Tables[0].Rows[0]["usu"]);
        //        dataset.Dispose();
        //    }


        //    return emple;
        //}


        //public bool modificarEmpleado(Empleado empl, Usuario usu)
        //{
        //    String consulta = "exec editarEmpleado '" + empl.getCedula() +
        //        "','" + empl.getNombre() + "','" + empl.getApellido() + "','" +
        //        empl.getFechaNacimiento() + "'," + empl.getCargoId() + "," +
        //        empl.getCiudadNacimiento() + "," + empl.getSucursalId() + ",'" +
        //        usu.getCuenta() + "','" + usu.getClave() + "'," + usu.getTipoUsuario() + "," +
        //        empl.getUsuarioId() + ";";
        //    return ejecutar(consulta);
        //}

        //public bool eliminarEmpleado(String cedula)
        //{
        //    String consulta = "exec borrarEmpleado '" + cedula + "';";
        //    return ejecutar(consulta);
        //}

    }
}
