using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class TipoCuenta
    {

        private Int32 id;
        private String nombre;
        private String descripcion;
        public TipoCuenta()
        {

        }

        public TipoCuenta(int id, string nombre, string descripcion)
        {
            // TODO: Complete member initialization
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
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
        public String getDescripcion()
        {
            return this.descripcion;
        }
        public void setDescripcion(String descripcion)
        {
            this.descripcion = descripcion;
        }
    }
}
