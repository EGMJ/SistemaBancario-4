namespace SistemaBancario.Navigation
{
    partial class FormGestionSucursal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionSucursal));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.cBPais = new System.Windows.Forms.ComboBox();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBanco = new SistemaBancario.DataSetBanco();
            this.cBDepartamento = new System.Windows.Forms.ComboBox();
            this.cBCiudad = new System.Windows.Forms.ComboBox();
            this.cBGerente = new System.Windows.Forms.ComboBox();
            this.tBDireccion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.paisTableAdapter = new SistemaBancario.DataSetBancoTableAdapters.paisTableAdapter();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoTableAdapter = new SistemaBancario.DataSetBancoTableAdapters.departamentoTableAdapter();
            this.bancoTableAdapter = new SistemaBancario.DataSetBancoTableAdapters.bancoTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gerenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listarSucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sucursalTableAdapter = new SistemaBancario.DataSetBancoTableAdapters.sucursalTableAdapter();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new SistemaBancario.DataSetBancoTableAdapters.usuarioTableAdapter();
            this.listarSucursalTableAdapter = new SistemaBancario.DataSetBancoTableAdapters.listarSucursalTableAdapter();
            this.departamentopaisFKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBanco)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarSucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentopaisFKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // tBNombre
            // 
            resources.ApplyResources(this.tBNombre, "tBNombre");
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBNombre_KeyPress);
            // 
            // cBPais
            // 
            this.cBPais.DataSource = this.paisBindingSource;
            this.cBPais.DisplayMember = "nombre";
            this.cBPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cBPais, "cBPais");
            this.cBPais.FormattingEnabled = true;
            this.cBPais.Name = "cBPais";
            this.cBPais.ValueMember = "id";
            this.cBPais.SelectedIndexChanged += new System.EventHandler(this.cBPais_SelectedIndexChanged);
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataMember = "pais";
            this.paisBindingSource.DataSource = this.dataSetBanco;
            // 
            // dataSetBanco
            // 
            this.dataSetBanco.DataSetName = "DataSetBanco";
            this.dataSetBanco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cBDepartamento
            // 
            this.cBDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cBDepartamento, "cBDepartamento");
            this.cBDepartamento.FormattingEnabled = true;
            this.cBDepartamento.Name = "cBDepartamento";
            this.cBDepartamento.SelectedIndexChanged += new System.EventHandler(this.cBDepartamento_SelectedIndexChanged);
            // 
            // cBCiudad
            // 
            this.cBCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cBCiudad, "cBCiudad");
            this.cBCiudad.FormattingEnabled = true;
            this.cBCiudad.Name = "cBCiudad";
            // 
            // cBGerente
            // 
            this.cBGerente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cBGerente, "cBGerente");
            this.cBGerente.FormattingEnabled = true;
            this.cBGerente.Name = "cBGerente";
            // 
            // tBDireccion
            // 
            resources.ApplyResources(this.tBDireccion, "tBDireccion");
            this.tBDireccion.Name = "tBDireccion";
            this.tBDireccion.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBDireccion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBGerente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cBCiudad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cBDepartamento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cBPais);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tBNombre);
            this.groupBox1.Controls.Add(this.label7);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // bancoBindingSource
            // 
            this.bancoBindingSource.DataMember = "banco";
            this.bancoBindingSource.DataSource = this.dataSetBanco;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            resources.ApplyResources(this.btnEditar, "btnEditar");
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // paisTableAdapter
            // 
            this.paisTableAdapter.ClearBeforeFill = true;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "departamento";
            this.departamentoBindingSource.DataSource = this.dataSetBanco;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // bancoTableAdapter
            // 
            this.bancoTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panel1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.bancoDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.gerenteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listarSucursalBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            resources.ApplyResources(this.nombreDataGridViewTextBoxColumn, "nombreDataGridViewTextBoxColumn");
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // bancoDataGridViewTextBoxColumn
            // 
            this.bancoDataGridViewTextBoxColumn.DataPropertyName = "banco";
            resources.ApplyResources(this.bancoDataGridViewTextBoxColumn, "bancoDataGridViewTextBoxColumn");
            this.bancoDataGridViewTextBoxColumn.Name = "bancoDataGridViewTextBoxColumn";
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad";
            resources.ApplyResources(this.ciudadDataGridViewTextBoxColumn, "ciudadDataGridViewTextBoxColumn");
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            resources.ApplyResources(this.direccionDataGridViewTextBoxColumn, "direccionDataGridViewTextBoxColumn");
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // gerenteDataGridViewTextBoxColumn
            // 
            this.gerenteDataGridViewTextBoxColumn.DataPropertyName = "gerente";
            resources.ApplyResources(this.gerenteDataGridViewTextBoxColumn, "gerenteDataGridViewTextBoxColumn");
            this.gerenteDataGridViewTextBoxColumn.Name = "gerenteDataGridViewTextBoxColumn";
            // 
            // listarSucursalBindingSource
            // 
            this.listarSucursalBindingSource.DataMember = "listarSucursal";
            this.listarSucursalBindingSource.DataSource = this.dataSetBanco;
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataMember = "sucursal";
            this.sucursalBindingSource.DataSource = this.dataSetBanco;
            // 
            // sucursalTableAdapter
            // 
            this.sucursalTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.dataSetBanco;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // listarSucursalTableAdapter
            // 
            this.listarSucursalTableAdapter.ClearBeforeFill = true;
            // 
            // departamentopaisFKBindingSource
            // 
            this.departamentopaisFKBindingSource.DataMember = "departamento_pais_FK";
            this.departamentopaisFKBindingSource.DataSource = this.paisBindingSource;
            // 
            // FormGestionSucursal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "FormGestionSucursal";
            this.Load += new System.EventHandler(this.FormGestionSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBanco)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarSucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentopaisFKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBDireccion;
        private System.Windows.Forms.ComboBox cBGerente;
        private System.Windows.Forms.ComboBox cBCiudad;
        private System.Windows.Forms.ComboBox cBDepartamento;
        private System.Windows.Forms.ComboBox cBPais;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private DataSetBanco dataSetBanco;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private DataSetBancoTableAdapters.paisTableAdapter paisTableAdapter;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private DataSetBancoTableAdapters.departamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.BindingSource bancoBindingSource;
        private DataSetBancoTableAdapters.bancoTableAdapter bancoTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private DataSetBancoTableAdapters.sucursalTableAdapter sucursalTableAdapter;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DataSetBancoTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource listarSucursalBindingSource;
        private DataSetBancoTableAdapters.listarSucursalTableAdapter listarSucursalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gerenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource departamentopaisFKBindingSource;
    }
}