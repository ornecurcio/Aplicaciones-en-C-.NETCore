
namespace Formulario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnMenuCirujano = new System.Windows.Forms.Button();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.lblAgregarPaciente = new System.Windows.Forms.Label();
            this.lblAgregarCirujano = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicio de Ortopedia y Traumatologia ";
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(108, 112);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(234, 106);
            this.btnPaciente.TabIndex = 1;
            this.btnPaciente.Text = "Menu Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnMenuCirujano
            // 
            this.btnMenuCirujano.Location = new System.Drawing.Point(459, 112);
            this.btnMenuCirujano.Name = "btnMenuCirujano";
            this.btnMenuCirujano.Size = new System.Drawing.Size(212, 106);
            this.btnMenuCirujano.TabIndex = 2;
            this.btnMenuCirujano.Text = "Menu Cirujano";
            this.btnMenuCirujano.UseVisualStyleBackColor = true;
            this.btnMenuCirujano.Click += new System.EventHandler(this.btnMenuCirujano_Click);
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Location = new System.Drawing.Point(108, 282);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(563, 129);
            this.btnEstadistica.TabIndex = 3;
            this.btnEstadistica.Text = "Estadisticas";
            this.btnEstadistica.UseVisualStyleBackColor = true;
            this.btnEstadistica.Click += new System.EventHandler(this.btnEstadistica_Click);
            // 
            // lblAgregarPaciente
            // 
            this.lblAgregarPaciente.AutoSize = true;
            this.lblAgregarPaciente.Location = new System.Drawing.Point(131, 221);
            this.lblAgregarPaciente.Name = "lblAgregarPaciente";
            this.lblAgregarPaciente.Size = new System.Drawing.Size(97, 15);
            this.lblAgregarPaciente.TabIndex = 4;
            this.lblAgregarPaciente.Text = "Agregar Paciente";
            this.lblAgregarPaciente.Click += new System.EventHandler(this.lblAgregarPaciente_Click);
            // 
            // lblAgregarCirujano
            // 
            this.lblAgregarCirujano.AutoSize = true;
            this.lblAgregarCirujano.Location = new System.Drawing.Point(475, 221);
            this.lblAgregarCirujano.Name = "lblAgregarCirujano";
            this.lblAgregarCirujano.Size = new System.Drawing.Size(97, 15);
            this.lblAgregarCirujano.TabIndex = 5;
            this.lblAgregarCirujano.Text = "Agregar Cirujano";
            this.lblAgregarCirujano.Click += new System.EventHandler(this.lblAgregarCirujano_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAgregarCirujano);
            this.Controls.Add(this.lblAgregarPaciente);
            this.Controls.Add(this.btnEstadistica);
            this.Controls.Add(this.btnMenuCirujano);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnMenuCirujano;
        private System.Windows.Forms.Button btnEstadistica;
        private System.Windows.Forms.Label lblAgregarPaciente;
        private System.Windows.Forms.Label lblAgregarCirujano;
    }
}

