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
        private TipoCuentaCosto()
        {

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
