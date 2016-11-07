using Platform.Object.model;
using Platform.Service.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Comunication.controller
{
   public class JuntaDirectivaController
    {
       JuntaDirectivaDAO juntaDAO = new JuntaDirectivaDAO();
       public MiembroJuntaDirectiva solicitudBuscar(String cedula)
       {
           return juntaDAO.buscarJunta(cedula);
       }

       public String solicitudGuardar(Int32 id, double acciones,String nombre,String apellido,String cedula,String fechaNacimiento, Int32 ciudadNacimiento,Int32 bancoId)
       {
           MiembroJuntaDirectiva entity = new MiembroJuntaDirectiva(id, acciones, nombre, apellido, cedula, fechaNacimiento, ciudadNacimiento, bancoId);
           return juntaDAO.guardarJunta(entity);
       }

       public string solicutudEliminar(int id)
       {
           return juntaDAO.eliminarJunta(id);
       }
    }
}
