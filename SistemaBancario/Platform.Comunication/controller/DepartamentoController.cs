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
       public LinkedList<Departamento> solicitudListaDeptosPorPais(int idPais)
       {
           DepartamentoDAO deptoDAO = new DepartamentoDAO();
           return deptoDAO.buscarDeptoPorPais(idPais);

       }
    }
}
