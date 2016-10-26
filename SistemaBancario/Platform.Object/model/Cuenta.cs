using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class Cuenta
    {
        private Int32 id;
        private Int32 numero;
        private Int32 tipoCuentaId;
        private Int32 clienteSucursalId;

        public Cuenta()
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

        public Int32 getNumero()
        {
            return this.numero;
        }
        public void setNumero(Int32 numero)
        {
            this.numero=numero;
        }
        public Int32 getTipoCuentaId()
        {
            return this.tipoCuentaId;
        }
        public void setTipoCuentaId(Int32 idTipoCuent)
        {
            this.tipoCuentaId=idTipoCuent;
        }
        public Int32 getclienteSucursalId()
        {
            return this.clienteSucursalId;
        }
        public void setClienteSucursalId(Int32 clienteSucursalId)
        {
            this.clienteSucursalId = clienteSucursalId;
        }
    }
}
