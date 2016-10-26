using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public  class Usuario
    {
        private Int32 id;
        private String cuenta;
        private String clave;
        private Int32 tipoUsuario;

        public Usuario() { 
        
        }

        public Int32 getId()
        {
            return this.id;
        }
        public void setId(Int32 id)
        {
            this.id = id;
        }
        public String getCuenta()
        {
            return this.cuenta;
        }
        public void setCuenta(String cuent) 
        {
            this.cuenta = cuent;
        }
        public String getClave()
        {
            return this.clave;
        }
        public void setClave(String clav)
        {
            this.clave = clav;
        }
        public Int32 getTipoUsuario()
        {
            return this.tipoUsuario;
        }
        public void setTipoUsuario(Int32 id)
        {
            this.tipoUsuario = id;
        }
    }
}
