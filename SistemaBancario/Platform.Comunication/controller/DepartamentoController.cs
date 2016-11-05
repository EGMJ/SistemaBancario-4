using Platform.Object.model;
using Platform.Service.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Comunication.controller
{
   public class DepartamentoController
    {
       DepartamentoDAO deptoDAO = new DepartamentoDAO();
       public LinkedList<Departamento> solicitudListaDeptosPorPais(int idPais)
       {
           
           return deptoDAO.buscarDeptoPorPais(idPais);

       }


       public Departamento solicitudBuscarPorId(int id)
       {
           return deptoDAO.buscarDepartamentoPorId(id);
       }

       public bool SolicitudGuardarDepartamento(String nombre, String desc, Int32 idPais)
       {
           Departamento dep = new Departamento(nombre, desc, idPais);
           return deptoDAO.guardarDepartamento(dep);
       }

       public Departamento SolicitudBuscarDepartamento(String nombre)
       {
           return deptoDAO.buscarDepartamento(nombre);
       }

       public bool SolicitudModificarDepartamento(String nombre, String descripcion, Int32 idPais)
       {
           Departamento dep = new Departamento(nombre,descripcion,idPais);
           return deptoDAO.modificarDepartamento(dep);
       }

       public bool solicitudEliminarPais(String nombre)
       {
           return deptoDAO.eliminarCiudad(nombre);
       }
    }
}
