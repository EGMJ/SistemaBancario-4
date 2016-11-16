using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class TipoCuentaCosto
    {
        private Int32 id;
        private Int32 tipoCuentaId;
        private Int32 costoId;
        public TipoCuentaCosto()
        {

        }
        public TipoCuentaCosto(Int32 cuentaId,Int32 costoID)
        {
            this.tipoCuentaId = cuentaId;
            this.costoId = costoID;
        }

        public TipoCuentaCosto(Int32 id,Int32 cuentaId, Int32 costoID)
        {
            this.id = id;
            this.tipoCuentaId = cuentaId;
            this.costoId = costoID;
        }

        public Int32 getId()
        {
            return this.id;
        }
        public void setId(Int32 id)
        {
            this.id = id;
        }
        public Int32 getTipoCuentaId()
        {
            return this.tipoCuentaId;
        }
        public void setTipoCuentaId(Int32 id)
        {
            this.tipoCuentaId = id;
        }
        public Int32 getCostoId()
        {
            return this.costoId;
        }
        public void setCostoId(Int32 id)
        {
            this.costoId = id;
        }
    }
}
