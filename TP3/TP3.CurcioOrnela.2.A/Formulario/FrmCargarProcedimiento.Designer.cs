
namespace Formulario
{
    partial class FrmCargarProcedimiento
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
            this.lblPersona = new System.Windows.Forms.Label();
            this.lblPacientevsCirujano = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbApellidoNombre = new System.Windows.Forms.ComboBox();
            this.cmbPacientevsCirujano = new System.Windows.Forms.ComboBox();
            this.cmbProcedimiento = new System.Windows.Forms.ComboBox();
            this.lblPatologia = new System.Windows.Forms.Label();
            this.cmbPatologia = new System.Windows.Forms.ComboBox();
            this.lblAgregarNuevo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(80, 9);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(49, 15);
            this.lblPersona.TabIndex = 0;
            this.lblPersona.Text = "Persona";
            // 
            // lblPacientevsCirujano
            // 
            this.lblPacientevsCirujano.AutoSize = true;
            this.lblPacientevsCirujano.Location = new System.Drawing.Point(80, 65);
            this.lblPacientevsCirujano.Name = "lblPacientevsCirujano";
            this.lblPacientevsCirujano.Size = new System.Drawing.Size(24, 15);
            this.lblPacientevsCirujano.TabIndex = 1;
            this.lblPacientevsCirujano.Text = "Rol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Procedimiento";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(312, 340);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbApellidoNombre
            // 
            this.cmbApellidoNombre.FormattingEnabled = true;
            this.cmbApellidoNombre.Location = new System.Drawing.Point(80, 27);
            this.cmbApellidoNombre.Name = "cmbApellidoNombre";
            this.cmbApellidoNombre.Size = new System.Drawing.Size(218, 23);
            this.cmbApellidoNombre.TabIndex = 6;
            // 
            // cmbPacientevsCirujano
            // 
            this.cmbPacientevsCirujano.FormattingEnabled = true;
            this.cmbPacientevsCirujano.Location = new System.Drawing.Point(80, 83);
            this.cmbPacientevsCirujano.Name = "cmbPacientevsCirujano";
            this.cmbPacientevsCirujano.Size = new System.Drawing.Size(218, 23);
            this.cmbPacientevsCirujano.TabIndex = 7;
            // 
            // cmbProcedimiento
            // 
            this.cmbProcedimiento.FormattingEnabled = true;
            this.cmbProcedimiento.Location = new System.Drawing.Point(80, 248);
            this.cmbProcedimiento.Name = "cmbProcedimiento";
            this.cmbProcedimiento.Size = new System.Drawing.Size(218, 23);
            this.cmbProcedimiento.TabIndex = 10;
            // 
            // lblPatologia
            // 
            this.lblPatologia.AutoSize = true;
            this.lblPatologia.Location = new System.Drawing.Point(80, 163);
            this.lblPatologia.Name = "lblPatologia";
            this.lblPatologia.Size = new System.Drawing.Size(57, 15);
            this.lblPatologia.TabIndex = 11;
            this.lblPatologia.Text = "Patologia";
            // 
            // cmbPatologia
            // 
            this.cmbPatologia.FormattingEnabled = true;
            this.cmbPatologia.Location = new System.Drawing.Point(80, 181);
            this.cmbPatologia.Name = "cmbPatologia";
            this.cmbPatologia.Size = new System.Drawing.Size(218, 23);
            this.cmbPatologia.TabIndex = 12;
            this.cmbPatologia.SelectedIndexChanged += new System.EventHandler(this.cmbPatologia_SelectedIndexChanged);
            // 
            // lblAgregarNuevo
            // 
            this.lblAgregarNuevo.AutoSize = true;
            this.lblAgregarNuevo.Location = new System.Drawing.Point(211, 53);
            this.lblAgregarNuevo.Name = "lblAgregarNuevo";
            this.lblAgregarNuevo.Size = new System.Drawing.Size(87, 15);
            this.lblAgregarNuevo.TabIndex = 13;
            this.lblAgregarNuevo.Text = "Agregar Nuevo";
            this.lblAgregarNuevo.Click += new System.EventHandler(this.lblAgregarNuevo_Click);
            // 
            // FrmCargarProcedimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 375);
            this.Controls.Add(this.lblAgregarNuevo);
            this.Controls.Add(this.cmbPatologia);
            this.Controls.Add(this.lblPatologia);
            this.Controls.Add(this.cmbProcedimiento);
            this.Controls.Add(this.cmbPacientevsCirujano);
            this.Controls.Add(this.cmbApellidoNombre);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPacientevsCirujano);
            this.Controls.Add(this.lblPersona);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCargarProcedimiento";
            this.Text = "Cargar Procedimiento";
            this.Load += new System.EventHandler(this.FrmCargarProcedimiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.Label lblPacientevsCirujano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbApellidoNombre;
        private System.Windows.Forms.ComboBox cmbPacientevsCirujano;
        private System.Windows.Forms.ComboBox cmbProcedimiento;
        private System.Windows.Forms.Label lblPatologia;
        private System.Windows.Forms.ComboBox cmbPatologia;
        private System.Windows.Forms.Label lblAgregarNuevo;
    }
}