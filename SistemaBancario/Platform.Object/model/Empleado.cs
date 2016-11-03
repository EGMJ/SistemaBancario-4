using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class Empleado
    {
        private Int32 id;
        private String nombre;
        private String apellido;
        private String cedula;
        private String fechaNacimiento;
        private Int32 ciudadNacimiento;
        private Int32 sucursalId;
        private Int32 cargoId;
       

        public Empleado()
        {

        }

        public Empleado(String nombre,String apellido, String cedula, String fechaNacimiento,
            Int32 ciudadNacimiento, Int32 sucursalId, Int32 cargoId )
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.fechaNacimiento = fechaNacimiento;
            this.ciudadNacimiento = ciudadNacimiento;
            this.sucursalId = sucursalId;
            this.cargoId = cargoId;
        }

        public Empleado(int id, string nombre)
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

        public Int32 getCiudadNacimiento()
        {
            return this.ciudadNacimiento;
        }
        public void setCiudadNacimiento(Int32 ciudadNacimi)
        {
            this.ciudadNacimiento = ciudadNacimi;
        }

        public Int32 getSucursalId()
        {
            return this.sucursalId;
        }

        public void setSucursalId(Int32 sucursalID)
        {
            this.sucursalId = sucursalID;
        }

        public Int32 getCargoId()
        {
            return this.cargoId;
        }
        public void setCargoId(Int32 cargoID)
        {
            this.cargoId = cargoID;
        }
    }
}
