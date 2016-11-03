using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class Sucursal
    {
        private Int32 id;
        private String nombre;
        private Int32 bancoId;
        private Int32 ciudadId;
        private Int32 gerenteId;
        private String direccion;
        //auxiliares para busqueda de la sucursal 
        public Int32 idPais { get; set; }
        public Int32 idDepartamento { get; set; }

        public Sucursal()
        {

        }

        public Sucursal(int id, string nombre, int bancoId, int ciudadId, int gerenteId, string direccion)
        {
            // TODO: Complete member initialization
            this.id = id;
            this.nombre = nombre;
            this.bancoId = bancoId;
            this.ciudadId = ciudadId;
            this.gerenteId = gerenteId;
            this.direccion = direccion;
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
        public Int32 getBancoId()
        {
            return this.bancoId;
        }
        public void setBancoId(Int32 id)
        {
            this.bancoId = id;
        }

        public Int32 getCiudadId()
        {
            return this.ciudadId;
        }
        public void setCiudadId(Int32 id)
        {
            this.ciudadId = id;
        }
        public Int32 getGerenteId()
        {
            return this.gerenteId;
        }
        public void setGerenteId(Int32 id)
        {
            this.gerenteId = id;
        }

        public String getDireccion()
        {
            return this.direccion;
        }
        public void setDireccion(String direcc)
        {
            this.direccion = direcc;
        }
    }
}
