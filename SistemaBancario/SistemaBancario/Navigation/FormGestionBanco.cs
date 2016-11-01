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
    public partial class FormGestionBanco : Form
    {
        public FormGestionBanco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nit = txtNit.Text;
            String nombre = txtNombreBanco.Text;
            String descripcion = txtDescrpcion.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
