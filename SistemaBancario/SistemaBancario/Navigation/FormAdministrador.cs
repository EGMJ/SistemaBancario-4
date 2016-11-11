using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        FormGestionCliente formGestionCliente;
        FormGestionBanco formBanco;        
        FormGestionSucursal formSucursal;
        FormGestionJunta formJunta;
        FormGestionEmpleado formEmpleado;
        FormGestionCargo formCargo;
        FormGestionTipoCuenta formTipoCuenta;
        FormGestionPais formPais;
        FormGestionDepartamento formDepto;
        FormGestionCosto formGestionCosto;
        FormGestionCostoCuenta formCostCuen;
        c formCiudad;
        

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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread hiloInterfaz;
            this.Close();
            hiloInterfaz = new System.Threading.Thread(new System.Threading.ThreadStart(abrirLogin));
            this.Close();
            hiloInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
            hiloInterfaz.Start();
            
        }

        private void formCiudad_FormClosed(object sender, FormClosedEventArgs e)
        {
            formCiudad = null;
        }
        
        private void gestionarCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formCiudad == null)
            {
                formCiudad = new c();
                formCiudad.MdiParent = this;
                formCiudad.FormClosed += new FormClosedEventHandler(formCiudad_FormClosed);

                formCiudad.Show();
            }
            else
                formCiudad.Activate();
        }
        public void abrirLogin()
        {
            Login menu = new Login();
            menu.ShowDialog();
        }

        private void gestionClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(formGestionCliente == null)
            {
                formGestionCliente = new FormGestionCliente();
                formGestionCliente.MdiParent = this;
                formGestionCliente.FormClosed += new FormClosedEventHandler(formCliente_FormClosed);

                formGestionCliente.Show();
            }
            else
            {
                formGestionCliente.Activate();
            }
        }

        private void formCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            formGestionCliente = null;
        }
        private void formCosto_FormClosed(object sender, FormClosedEventArgs e)
        {
            formGestionCosto = null;
        }

        private void formCostCuent_FormClosed(object sender, FormClosedEventArgs e)
        {
            formCostCuen = null;
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void gestionarCostosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formGestionCosto == null)
            {
                formGestionCosto = new FormGestionCosto();
                formGestionCosto.MdiParent = this;
                formGestionCosto.FormClosed += new FormClosedEventHandler(formCosto_FormClosed);
                formGestionCosto.Show();
            }
            else
                formGestionCosto.Activate();
        }

        private void gestionarCuentaCostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formCostCuen == null)
            {
                formCostCuen = new FormGestionCostoCuenta();
                formCostCuen.MdiParent = this;
                formCostCuen.FormClosed += new FormClosedEventHandler(formCostCuent_FormClosed);
                formCostCuen.Show();
            }
            else
                formCostCuen.Activate();
        }
    }
}
