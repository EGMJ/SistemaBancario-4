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
    }
}
