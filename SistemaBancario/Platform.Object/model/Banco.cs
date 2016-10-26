using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class Banco
    {

        private Int32 id;
        private String nit;
        private String nombre;
        private String descripcion;

        public Banco()
        {

        }
        public Banco(Int32 id, String nit, String nombre, String descripcion)
        {
            this.id = id;
            this.nit = nit;
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

        public String getNit()
        {
            return this.nit;
        }

        public void setNit(String nit)
        {
            this.nit = nit;
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

        public void setDescripcion(String descri)
        {
            this.descripcion = descri;
        }
    }
}
