namespace SistemaBancario.Navigation
{
    partial class FormGestionBanco
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
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtNombreBanco = new System.Windows.Forms.TextBox();
            this.txtDescrpcion = new System.Windows.Forms.TextBox();
            this.txtMision = new System.Windows.Forms.TextBox();
            this.txtVision = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(116, 26);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(100, 20);
            this.txtNit.TabIndex = 0;
            // 
            // txtNombreBanco
            // 
            this.txtNombreBanco.Location = new System.Drawing.Point(116, 67);
            this.txtNombreBanco.Name = "txtNombreBanco";
            this.txtNombreBanco.Size = new System.Drawing.Size(100, 20);
            this.txtNombreBanco.TabIndex = 1;
            // 
            // txtDescrpcion
            // 
            this.txtDescrpcion.Location = new System.Drawing.Point(116, 123);
            this.txtDescrpcion.Multiline = true;
            this.txtDescrpcion.Name = "txtDescrpcion";
            this.txtDescrpcion.Size = new System.Drawing.Size(226, 52);
            this.txtDescrpcion.TabIndex = 2;
            // 
            // txtMision
            // 
            this.txtMision.Location = new System.Drawing.Point(417, 23);
            this.txtMision.Multiline = true;
            this.txtMision.Name = "txtMision";
            this.txtMision.Size = new System.Drawing.Size(176, 81);
            this.txtMision.TabIndex = 3;
            // 
            // txtVision
            // 
            this.txtVision.Location = new System.Drawing.Point(417, 123);
            this.txtVision.Multiline = true;
            this.txtVision.Name = "txtVision";
            this.txtVision.Size = new System.Drawing.Size(176, 85);
            this.txtVision.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mision";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vision";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(166, 204);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FormGestionBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 299);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVision);
            this.Controls.Add(this.txtMision);
            this.Controls.Add(this.txtDescrpcion);
            this.Controls.Add(this.txtNombreBanco);
            this.Controls.Add(this.txtNit);
            this.Name = "FormGestionBanco";
            this.Text = "FormGestionBanco";
            this.Load += new System.EventHandler(this.FormGestionBanco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtNombreBanco;
        private System.Windows.Forms.TextBox txtDescrpcion;
        private System.Windows.Forms.TextBox txtMision;
        private System.Windows.Forms.TextBox txtVision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModificar;
    }
}