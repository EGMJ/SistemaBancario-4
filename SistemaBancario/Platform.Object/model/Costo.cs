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
        private double monto;
        public Costo()
        {

        }

        public Costo(String nombre, double monto)
        {
            this.nombre = nombre;
            this.monto = monto;
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
        public double getMonto()
        {
            return this.monto;
        }
        public void setMonto(double monto)
        {
            this.monto = monto;
        }
    }
}
