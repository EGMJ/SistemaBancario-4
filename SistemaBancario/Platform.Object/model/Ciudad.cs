using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class Ciudad
    {
        private Int32 id;
        private String nombre;
        private String descripcion;
        private Int32 departamentoId;
       

        public Ciudad()
        {

        }

        public Ciudad(String nombre, String descri, Int32 deptoID)
        {
            this.nombre = nombre;
            this.descripcion = descri;
            this.departamentoId = deptoID;
        }

        public Ciudad(int id, string nombre)
        {

            this.id = id;
            this.nombre = nombre;
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
        public void setDescripcion(String desc)
        {
            this.descripcion = desc;
        }
        public Int32 getIdDepartamento()
        {
            return this.departamentoId;
        }
        public void setIdDepartamento(Int32 idDepto)
        {
            this.departamentoId = idDepto;
        }
    }
}
