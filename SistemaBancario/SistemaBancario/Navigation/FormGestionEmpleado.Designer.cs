namespace SistemaBancario.Navigation
{
    partial class FormGestionEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.ciudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBanco = new SistemaBancario.DataSetBanco();
            this.cbCrgo = new System.Windows.Forms.ComboBox();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtPrueba = new System.Windows.Forms.TextBox();
            this.dataSetBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadTableAdapter = new SistemaBancario.DataSetBancoTableAdapters.ciudadTableAdapter();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new SistemaBancario.DataSetBancoTableAdapters.usuarioTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.tipousuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_usuarioTableAdapter = new SistemaBancario.DataSetBancoTableAdapters.tipo_usuarioTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sucursalTableAdapter = new SistemaBancario.DataSetBancoTableAdapters.sucursalTableAdapter();
            this.cargoTableAdapter = new SistemaBancario.DataSetBancoTableAdapters.cargoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipousuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cargo";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(167, 12);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(160, 20);
            this.txtCedula.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(167, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(167, 82);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(160, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(169, 111);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 11;
            // 
            // cbCiudad
            // 
            this.cbCiudad.DataSource = this.ciudadBindingSource;
            this.cbCiudad.DisplayMember = "nombre";
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(167, 145);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cbCiudad.TabIndex = 12;
            this.cbCiudad.ValueMember = "id";
            // 
            // ciudadBindingSource
            // 
            this.ciudadBindingSource.DataMember = "ciudad";
            this.ciudadBindingSource.DataSource = this.dataSetBanco;
            // 
            // dataSetBanco
            // 
            this.dataSetBanco.DataSetName = "DataSetBanco";
            this.dataSetBanco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbCrgo
            // 
            this.cbCrgo.DataSource = this.cargoBindingSource;
            this.cbCrgo.DisplayMember = "nombre";
            this.cbCrgo.FormattingEnabled = true;
            this.cbCrgo.Location = new System.Drawing.Point(166, 178);
            this.cbCrgo.Name = "cbCrgo";
            this.cbCrgo.Size = new System.Drawing.Size(121, 21);
            this.cbCrgo.TabIndex = 14;
            this.cbCrgo.ValueMember = "id";
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataMember = "cargo";
            this.cargoBindingSource.DataSource = this.dataSetBanco;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(421, 37);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(423, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(424, 132);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(424, 178);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(424, 220);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtPrueba
            // 
            this.txtPrueba.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrueba.Location = new System.Drawing.Point(12, 12);
            this.txtPrueba.Name = "txtPrueba";
            this.txtPrueba.Size = new System.Drawing.Size(10, 20);
            this.txtPrueba.TabIndex = 20;
            // 
            // dataSetBancoBindingSource
            // 
            this.dataSetBancoBindingSource.DataSource = this.dataSetBanco;
            this.dataSetBancoBindingSource.Position = 0;
            // 
            // ciudadTableAdapter
            // 
            this.ciudadTableAdapter.ClearBeforeFill = true;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cuenta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Contraseña";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tipo de Usuario";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(167, 234);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(120, 20);
            this.txtCuenta.TabIndex = 24;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(166, 266);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(121, 20);
            this.txtContraseña.TabIndex = 25;
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.DataSource = this.tipousuarioBindingSource;
            this.cbTipoUsuario.DisplayMember = "nombre";
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(167, 295);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(150, 21);
            this.cbTipoUsuario.TabIndex = 26;
            this.cbTipoUsuario.ValueMember = "id";
            // 
            // tipousuarioBindingSource
            // 
            this.tipousuarioBindingSource.DataMember = "tipo_usuario";
            this.tipousuarioBindingSource.DataSource = this.dataSetBanco;
            // 
            // tipo_usuarioTableAdapter
            // 
            this.tipo_usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Sucursal";
            // 
            // cbSucursal
            // 
            this.cbSucursal.DataSource = this.sucursalBindingSource;
            this.cbSucursal.DisplayMember = "nombre";
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(166, 206);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cbSucursal.TabIndex = 28;
            this.cbSucursal.ValueMember = "id";
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
            // cargoTableAdapter
            // 
            this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // FormGestionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 335);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTipoUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrueba);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbCrgo);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGestionEmpleado";
            this.Text = "FormGestionEmpleado";
            this.Load += new System.EventHandler(this.FormGestionEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipousuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.ComboBox cbCrgo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtPrueba;
        private System.Windows.Forms.BindingSource dataSetBancoBindingSource;
        private DataSetBanco dataSetBanco;
        private System.Windows.Forms.BindingSource ciudadBindingSource;
        private DataSetBancoTableAdapters.ciudadTableAdapter ciudadTableAdapter;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DataSetBancoTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.BindingSource tipousuarioBindingSource;
        private DataSetBancoTableAdapters.tipo_usuarioTableAdapter tipo_usuarioTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private DataSetBancoTableAdapters.sucursalTableAdapter sucursalTableAdapter;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private DataSetBancoTableAdapters.cargoTableAdapter cargoTableAdapter;
    }
}