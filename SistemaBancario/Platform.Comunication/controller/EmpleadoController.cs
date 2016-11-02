using Platform.Object.model;
using Platform.Service.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Comunication.controller
{
   public class EmpleadoController
    {
       public LinkedList<Empleado> solicitudObtenerGerente()
       {
           EmpleadoDao empleadoDAO = new EmpleadoDao();
           return empleadoDAO.obtenerGerente();

       }
    }
}
