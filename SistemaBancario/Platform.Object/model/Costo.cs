using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class Costo
    {
        private Int32 id;
        private String nombre;
        private float monto;
        public Costo()
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
        public String getNombre()
        {
            return this.nombre;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public float getMonto()
        {
            return this.monto;
        }
        public void setMonto(float monto)
        {
            this.monto = monto;
        }
    }
}
