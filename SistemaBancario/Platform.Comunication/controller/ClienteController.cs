using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Object.model;
using Platform.Service.services;
namespace Platform.Comunication.controller
{
    public class ClienteController
    {

        ClienteDAO cliDao = new ClienteDAO();

        public bool SolicitudGuardarCliente(String nombre, String apellido, String cedula,
            String fechaNacimiento, Int32 usuarioId)
        {
            Cliente c = new Cliente(cedula,nombre,apellido,fechaNacimiento,usuarioId);
            return cliDao.guardarCliente(c);
        }

    }
}
