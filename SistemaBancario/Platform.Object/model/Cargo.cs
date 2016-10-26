using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class Cargo
    {
        private Int32 id { get; set; }
        private float salario { get; set; }
        private String nombre { get; set; }
        private Int32 cantidadHoras { get; set; }
        private String descripcion { get; set; }

        public Cargo()
        {

        }
    }
}
