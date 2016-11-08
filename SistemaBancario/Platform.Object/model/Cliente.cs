using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class Cliente
    {
        private Int32 id;
        private String nombre;
        private String apellido;
        private String cedula;
        private String fechaNacimiento;
        private Int32 usuarioId;
        public Cliente()
        {

        }

        public Cliente(String cedula,String nombre,String apellido,String fechaNa,Int32 usuId)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.fechaNacimiento = fechaNa;
            this.usuarioId = usuId;
        }

        public Int32 getIdUsuario()
        {
            return this.usuarioId;
        }
        public void setIdUsuario(Int32 usuId)
        {
            this.usuarioId = usuId;
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
        public String getApellido()
        {
            return this.apellido;
        }
        public void setApellido(String apellido)
        {
            this.apellido = apellido;
        }
        public String getCedula()
        {
            return this.cedula;
        }
        public void setCedula(String cedula)
        {
            this.cedula = cedula;
        }
        public String getFechaNacimiento()
        {
            return this.fechaNacimiento;
        }
        public void setFechaNacimiento(String fechaNa)
        {
            this.fechaNacimiento = fechaNa;
        }
    }
}
