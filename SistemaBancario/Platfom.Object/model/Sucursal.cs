using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platfom.Object.model
{
    class Sucursal
    {
        private Int32 id { get; set; }
        private String nombre { get; set; }
        private Int32 bancoId { get; set; }
        private Int32 ciudadId { get; set; }
        private Int32 gerenteId { get; set; }
        private String direccion { get; set; }

        public Sucursal()
        {

        }
    }
}
