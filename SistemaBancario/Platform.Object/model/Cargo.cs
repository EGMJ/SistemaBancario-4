using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Object.model
{
    public class Cargo
    {
        private Int32 id;
        private Double salario;
        private String nombre;
        private Int32 cantidadHoras;
        private String descripcion;

        public Cargo()
        {

        }

        public Cargo(Int32 id, double salario, String nombre, Int32 cantidadHoras, String descr)
        {
            this.id = id;
            this.salario = salario;
            this.nombre = nombre;
            this.cantidadHoras = cantidadHoras;
            this.descripcion = descr;
        }
        public Cargo(String nombre, double salario, Int32 cantidadHoras, String descr)
        {
            this.nombre = nombre;
            this.salario = salario;            
            this.cantidadHoras = cantidadHoras;
            this.descripcion = descr;
        }

        public Int32 getId()
        {
            return this.id;
        }

        public void setId(Int32 id)
        {
            this.id = id;
        }

        public Double getSalario()
        {
            return this.salario;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public Int32 getCantidadHoras()
        {
            return this.cantidadHoras;
        }
        public void setCantidadHoras(Int32 cantHor)
        {
            this.cantidadHoras = cantHor;
        }

        public String getDescripcion()
        {
            return this.descripcion;
        }
        public void setDescripcion(String desc)
        {
            this.descripcion = desc;
        }

    }
}
