using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class MiembroJuntaDirectiva
    {
        private Int32 id;
        private float acciones;
        private String nombre;
        private String apellido;
        private String cedula;
        private DateTime fechaNacimiento;
        private Int32 ciudadNacimiento;
        private Int32 bancoId;

        public MiembroJuntaDirectiva()
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

        public float getAcciones()
        {
            return this.acciones;
        }
        public void setAcciones(float acciones)
        {
            this.acciones = acciones;
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
        public DateTime getFechaNacimiento()
        {
            return this.fechaNacimiento;
        }
        public void setFechaNacimiento(DateTime fechaNa)
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
        public Int32 getBancoId()
        {
            return this.bancoId;
        }
        public void setBancoId(Int32 bancoID)
        {
            this.bancoId = bancoID;
        }
    }
}
