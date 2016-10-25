using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platfom.Object.model
{
    class Empleado
    {
        private Int32 id { get; set; }
        private String nombre { get; set; }
        private String apellido { get; set; }
        private String cedula { get; set; }
        private DateTime fechaNacimiento { get; set; }
        private Int32 ciudadNacimiento { get; set; }
        private Int32 sucursalId { get; set; }
        private Int32 cargoId { get; set; }

        public Empleado()
        {

        }
    }
}
