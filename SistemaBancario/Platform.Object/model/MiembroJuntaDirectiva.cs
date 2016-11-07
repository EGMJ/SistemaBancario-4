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
        private double acciones;
        private String nombre;
        private String apellido;
        private String cedula;
        private String fechaNacimiento;
        private Int32 ciudadNacimiento;
        private Int32 bancoId;
        //auxiliares para busqueda de la sucursal 
        public Int32 idPais { get; set; }
        public Int32 idDepartamento { get; set; }

        public MiembroJuntaDirectiva()
        {

        }

        public MiembroJuntaDirectiva(int id, double acciones, string nombre, string apellido, string cedula, string fechaNacimiento, int ciudadNacimiento, int bancoId)
        {
            this.id = id;
            this.acciones = acciones;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.fechaNacimiento = fechaNacimiento;
            this.ciudadNacimiento = ciudadNacimiento;
            this.bancoId = bancoId;
        }

        public Int32 getId()
        {
            return this.id;
        }
        public void setId(Int32 id)
        {
            this.id = id;
        }

        public double getAcciones()
        {
            return this.acciones;
        }
        public void setAcciones(double acciones)
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
