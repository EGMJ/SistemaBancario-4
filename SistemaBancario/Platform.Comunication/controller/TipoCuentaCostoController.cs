using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platform.Object.model;
using Platform.Service.services;
namespace Platform.Comunication.controller
{
    public class TipoCuentaCostoController
    {

        TipoCuentaCostoDAO costoCuentaDao = new TipoCuentaCostoDAO();

        public bool SolicitudGuardarCuentaCosto(Int32 cuentaId, Int32 costoId)
        {
            TipoCuentaCosto tcc = new TipoCuentaCosto(cuentaId,costoId);
            return costoCuentaDao.guardarCuentaCosto(tcc);
        }

        public TipoCuentaCosto SolicitudBuscarCuenCos(Int32 idCuenta)
        {
            return costoCuentaDao.buscarCuentaCosto(idCuenta);
        }

        public bool SolicitudModificarCuentaCos(Int32 id,Int32 cuentaId, Int32 costoId)
        {
            TipoCuentaCosto tcc = new TipoCuentaCosto(id,cuentaId,costoId);
            return costoCuentaDao.modificarCuentaCosto(tcc);
        }

        public bool solicitudEliminarCuentaCosto(Int32 id)
        {
            return costoCuentaDao.eliminarCuentaCosto(id);
        }

    }
}
