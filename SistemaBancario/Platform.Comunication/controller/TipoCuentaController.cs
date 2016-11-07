using Platform.Object.model;
using Platform.Service.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Comunication.controller
{
   public class TipoCuentaController
    {
       TipoCuentaDAO tipoDAO = new TipoCuentaDAO();
       public TipoCuenta solicitudBuscar(String nombre)
       {
           return tipoDAO.buscarTipoCuenta(nombre);

       }

       public String solicitudGuardar(Int32 id, String nombre, String descripcion)
       {
           TipoCuenta entity = new TipoCuenta(id, nombre, descripcion);
           return tipoDAO.guardarTipoCuenta(entity);
       }

       public String solicitudEditar(Int32 id, String nombre, String descripcion)
       {
           TipoCuenta entity = new TipoCuenta(id, nombre, descripcion);
           return tipoDAO.guardarTipoCuenta(entity);
       }

       public String solicutudEliminar(Int32 id)
        {
            return tipoDAO.eliminarTipoCuenta(id);
        }

       }
    }

