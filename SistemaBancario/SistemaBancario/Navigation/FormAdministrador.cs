using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario.Navigation
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }

        FormGestionBanco formBanco;
        FormGestionSucursal formSucursal;
        FormGestionJunta formJunta;
        FormGestionEmpleado formEmpleado;
        FormGestionCargo formCargo;
        FormGestionTipoCuenta formTipoCuenta;
        FormGestionPais formPais;
        FormGestionDepartamento formDepto;
        private void gestionEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formEmpleado == null)
            {
                formEmpleado = new FormGestionEmpleado();
                formEmpleado.MdiParent = this;
                formEmpleado.FormClosed += new FormClosedEventHandler(formEmpleado_FormClosed);
                formEmpleado.Show();
            }
            else
                formEmpleado.Activate();
        }

        void formEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            formEmpleado = null;
        }

        private void gestionarBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formBanco == null)
            {
                formBanco = new FormGestionBanco();
                formBanco.MdiParent = this;
                formBanco.FormClosed += new FormClosedEventHandler(formBanco_FormClosed);
                formBanco.Show();
            }
            else
                formBanco.Activate();
        }

        void formBanco_FormClosed(object sender, FormClosedEventArgs e)
        {
            formBanco = null;
        }

        private void gestionarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formSucursal == null)
            {
                formSucursal = new FormGestionSucursal();
                formSucursal.MdiParent = this;
                formSucursal.FormClosed += new FormClosedEventHandler(formSucursal_FormClosed);
 ;
                formSucursal.Show();
            }
            else
                formSucursal.Activate();
        }

        private void formSucursal_FormClosed(object sender, FormClosedEventArgs e)
        {
            formSucursal = null;
        }

        private void gestionJuntaDirectivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formJunta == null)
            {
                formJunta = new FormGestionJunta();
                formJunta.MdiParent = this;
                formJunta.FormClosed += new FormClosedEventHandler(formJunta_FormClosed);
                
                formJunta.Show();
            }
            else
                formJunta.Activate();
        }

        private void formJunta_FormClosed(object sender, FormClosedEventArgs e)
        {
            formJunta = null;
        }

        private void gestionCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formCargo == null)
            {
                formCargo = new FormGestionCargo();
                formCargo.MdiParent = this;
                formCargo.FormClosed += new FormClosedEventHandler(formCargo_FormClosed);

                formCargo.Show();
            }
            else
                formCargo.Activate();
        }

        private void formCargo_FormClosed(object sender, FormClosedEventArgs e)
        {
            formCargo = null;
        }

        private void gestionTipoCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formTipoCuenta == null)
            {
                formTipoCuenta = new FormGestionTipoCuenta();
                formTipoCuenta.MdiParent = this;
                formTipoCuenta.FormClosed += new FormClosedEventHandler(formTipoCuenta_FormClosed);

                formTipoCuenta.Show();
            }
            else
                formTipoCuenta.Activate();
        }

        private void formTipoCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            formTipoCuenta = null;
        }

        private void gestionPaísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formPais == null)
            {
                formPais = new FormGestionPais();
                formPais.MdiParent = this;
                formPais.FormClosed += new FormClosedEventHandler(formPais_FormClosed);

                formPais.Show();
            }
            else
                formPais.Activate();
        }

        private void formPais_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPais = null;
        }

        private void gestionDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formDepto == null)
            {
                formDepto = new FormGestionDepartamento();
                formDepto.MdiParent = this;
                formDepto.FormClosed += new FormClosedEventHandler(formDepto_FormClosed);

                formDepto.Show();
            }
            else
                formDepto.Activate();
        }

        private void formDepto_FormClosed(object sender, FormClosedEventArgs e)
        {
            formDepto = null;
        }
    }
}
