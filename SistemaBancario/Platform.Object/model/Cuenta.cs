using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class Cuenta
    {
        private Int32 id { get; set; }
        private Int32 numero { get; set; }
        private Int32 tipoCuentaId { get; set; }
        private Int32 clienteSucursalId { get; set; }

        public Cuenta()
        {

        }
    }
}
