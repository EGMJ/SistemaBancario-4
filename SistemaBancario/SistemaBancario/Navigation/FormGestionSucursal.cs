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
    public partial class FormGestionSucursal : Form
    {
        public FormGestionSucursal()
        {
            InitializeComponent();
        }

        private void FormGestionSucursal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetBanco.pais' Puede moverla o quitarla según sea necesario.
            this.paisTableAdapter.Fill(this.dataSetBanco.pais);

        }
    }
}
