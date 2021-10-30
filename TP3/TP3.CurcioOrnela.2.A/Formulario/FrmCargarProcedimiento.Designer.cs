
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
            this.lblRol = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbApellidoNombre = new System.Windows.Forms.ComboBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.cmbProcedimiento = new System.Windows.Forms.ComboBox();
            this.lblPatologia = new System.Windows.Forms.Label();
            this.cmbPatologia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(80, 32);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(49, 15);
            this.lblPersona.TabIndex = 0;
            this.lblPersona.Text = "Persona";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(80, 108);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(24, 15);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbApellidoNombre
            // 
            this.cmbApellidoNombre.FormattingEnabled = true;
            this.cmbApellidoNombre.Location = new System.Drawing.Point(80, 70);
            this.cmbApellidoNombre.Name = "cmbApellidoNombre";
            this.cmbApellidoNombre.Size = new System.Drawing.Size(218, 23);
            this.cmbApellidoNombre.TabIndex = 6;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(80, 126);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(218, 23);
            this.cmbRol.TabIndex = 7;
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
            // FrmCargarProcedimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 356);
            this.Controls.Add(this.cmbPatologia);
            this.Controls.Add(this.lblPatologia);
            this.Controls.Add(this.cmbProcedimiento);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.cmbApellidoNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRol);
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
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbApellidoNombre;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.ComboBox cmbProcedimiento;
        private System.Windows.Forms.Label lblPatologia;
        private System.Windows.Forms.ComboBox cmbPatologia;
    }
}