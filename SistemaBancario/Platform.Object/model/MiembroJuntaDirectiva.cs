using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class MiembroJuntaDirectiva
    {
        private Int32 id { get; set; }
        private float acciones { get; set; }
        private String nombre { get; set; }
        private String apellido { get; set; }
        private String cedula { get; set; }
        private DateTime fechaNacimiento { get; set; }
        private Int32 ciudadNacimiento { get; set; }
        private Int32 bancoId { get; set; }

        public MiembroJuntaDirectiva()
        {

        }
    }
}
