using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class Departamento
    {
        private int id;
        private String nombre;
        private String descripcion;
        private Int32 paisId;
        

        public Departamento()
        {

        }

        public Departamento(int id, string nombre)
        {
            // TODO: Complete member initialization
            this.id = id;
            this.nombre = nombre;
        }

        public Departamento(String nombre, string descripcion, Int32 idPais)
        {
            // TODO: Complete member initialization
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.paisId = idPais;
        }

        public int getId()
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
        public Int32 getPaisId()
        {
            return this.paisId;
        }
        public void setPaisId(Int32 idPais)
        {
            this.paisId=idPais;
        }
    }
}
