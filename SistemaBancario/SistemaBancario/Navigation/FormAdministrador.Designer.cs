namespace SistemaBancario.Navigation
{
    partial class FormAdministrador
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionJuntaDirectivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionTipoCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPaísToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.bancoToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.administraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // bancoToolStripMenuItem
            // 
            this.bancoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarBancoToolStripMenuItem,
            this.gestionarSucursalToolStripMenuItem,
            this.gestionJuntaDirectivaToolStripMenuItem});
            this.bancoToolStripMenuItem.Name = "bancoToolStripMenuItem";
            this.bancoToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.bancoToolStripMenuItem.Text = "Banco";
            // 
            // gestionarBancoToolStripMenuItem
            // 
            this.gestionarBancoToolStripMenuItem.Name = "gestionarBancoToolStripMenuItem";
            this.gestionarBancoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.gestionarBancoToolStripMenuItem.Text = "Gestionar Banco";
            this.gestionarBancoToolStripMenuItem.Click += new System.EventHandler(this.gestionarBancoToolStripMenuItem_Click);
            // 
            // gestionarSucursalToolStripMenuItem
            // 
            this.gestionarSucursalToolStripMenuItem.Name = "gestionarSucursalToolStripMenuItem";
            this.gestionarSucursalToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.gestionarSucursalToolStripMenuItem.Text = "Gestionar Sucursal";
            this.gestionarSucursalToolStripMenuItem.Click += new System.EventHandler(this.gestionarSucursalToolStripMenuItem_Click);
            // 
            // gestionJuntaDirectivaToolStripMenuItem
            // 
            this.gestionJuntaDirectivaToolStripMenuItem.Name = "gestionJuntaDirectivaToolStripMenuItem";
            this.gestionJuntaDirectivaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.gestionJuntaDirectivaToolStripMenuItem.Text = "Gestion Junta Directiva";
            this.gestionJuntaDirectivaToolStripMenuItem.Click += new System.EventHandler(this.gestionJuntaDirectivaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionEmpleadoToolStripMenuItem,
            this.gestionClienteToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // gestionEmpleadoToolStripMenuItem
            // 
            this.gestionEmpleadoToolStripMenuItem.Name = "gestionEmpleadoToolStripMenuItem";
            this.gestionEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionEmpleadoToolStripMenuItem.Text = "Gestionar Empleado";
            this.gestionEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.gestionEmpleadoToolStripMenuItem_Click);
            // 
            // gestionClienteToolStripMenuItem
            // 
            this.gestionClienteToolStripMenuItem.Name = "gestionClienteToolStripMenuItem";
            this.gestionClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionClienteToolStripMenuItem.Text = "Gestionar Cliente";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionCargoToolStripMenuItem,
            this.gestionTipoCuentaToolStripMenuItem,
            this.gestionPaísToolStripMenuItem,
            this.gestionDepartamentoToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // gestionCargoToolStripMenuItem
            // 
            this.gestionCargoToolStripMenuItem.Name = "gestionCargoToolStripMenuItem";
            this.gestionCargoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.gestionCargoToolStripMenuItem.Text = "Gestionar Cargo";
            this.gestionCargoToolStripMenuItem.Click += new System.EventHandler(this.gestionCargoToolStripMenuItem_Click);
            // 
            // gestionTipoCuentaToolStripMenuItem
            // 
            this.gestionTipoCuentaToolStripMenuItem.Name = "gestionTipoCuentaToolStripMenuItem";
            this.gestionTipoCuentaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.gestionTipoCuentaToolStripMenuItem.Text = "Gestionar Tipo Cuenta";
            this.gestionTipoCuentaToolStripMenuItem.Click += new System.EventHandler(this.gestionTipoCuentaToolStripMenuItem_Click);
            // 
            // gestionPaísToolStripMenuItem
            // 
            this.gestionPaísToolStripMenuItem.Name = "gestionPaísToolStripMenuItem";
            this.gestionPaísToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.gestionPaísToolStripMenuItem.Text = "Gestionar País";
            this.gestionPaísToolStripMenuItem.Click += new System.EventHandler(this.gestionPaísToolStripMenuItem_Click);
            // 
            // gestionDepartamentoToolStripMenuItem
            // 
            this.gestionDepartamentoToolStripMenuItem.Name = "gestionDepartamentoToolStripMenuItem";
            this.gestionDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.gestionDepartamentoToolStripMenuItem.Text = "Gestionar Departamento";
            this.gestionDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.gestionDepartamentoToolStripMenuItem_Click);
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 356);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormAdministrador";
            this.Text = "FormAdministrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionJuntaDirectivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionTipoCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionPaísToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDepartamentoToolStripMenuItem;
    }
}