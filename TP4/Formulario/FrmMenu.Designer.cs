
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnMenuCirujano = new System.Windows.Forms.Button();
            this.btnVerListado = new System.Windows.Forms.Button();
            this.btnEstadisticaHospital = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cirujanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuirofano = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Blue;
            this.lblTitulo.Location = new System.Drawing.Point(106, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(465, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Servicio de Ortopedia y Traumatologia ";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPaciente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPaciente.Location = new System.Drawing.Point(58, 103);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(253, 106);
            this.btnPaciente.TabIndex = 1;
            this.btnPaciente.Text = "Menu Paciente";
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnMenuCirujano
            // 
            this.btnMenuCirujano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMenuCirujano.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuCirujano.Location = new System.Drawing.Point(385, 103);
            this.btnMenuCirujano.Name = "btnMenuCirujano";
            this.btnMenuCirujano.Size = new System.Drawing.Size(253, 106);
            this.btnMenuCirujano.TabIndex = 2;
            this.btnMenuCirujano.Text = "Menu Cirujano";
            this.btnMenuCirujano.UseVisualStyleBackColor = false;
            this.btnMenuCirujano.Click += new System.EventHandler(this.btnMenuCirujano_Click);
            // 
            // btnVerListado
            // 
            this.btnVerListado.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVerListado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerListado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerListado.Location = new System.Drawing.Point(58, 374);
            this.btnVerListado.Name = "btnVerListado";
            this.btnVerListado.Size = new System.Drawing.Size(580, 129);
            this.btnVerListado.TabIndex = 3;
            this.btnVerListado.Text = "Ver Listado Cirugias Realizadas";
            this.btnVerListado.UseVisualStyleBackColor = false;
            this.btnVerListado.Click += new System.EventHandler(this.btnVerListado_Click);
            // 
            // btnEstadisticaHospital
            // 
            this.btnEstadisticaHospital.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEstadisticaHospital.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticaHospital.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEstadisticaHospital.Location = new System.Drawing.Point(58, 532);
            this.btnEstadisticaHospital.Name = "btnEstadisticaHospital";
            this.btnEstadisticaHospital.Size = new System.Drawing.Size(580, 129);
            this.btnEstadisticaHospital.TabIndex = 6;
            this.btnEstadisticaHospital.Text = "Estadisticas del Hospital";
            this.btnEstadisticaHospital.UseVisualStyleBackColor = false;
            this.btnEstadisticaHospital.Click += new System.EventHandler(this.btnEstadisticaHospital_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.cirujanoToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // cirujanoToolStripMenuItem
            // 
            this.cirujanoToolStripMenuItem.Name = "cirujanoToolStripMenuItem";
            this.cirujanoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.cirujanoToolStripMenuItem.Text = "Cirujano";
            this.cirujanoToolStripMenuItem.Click += new System.EventHandler(this.cirujanoToolStripMenuItem_Click);
            // 
            // btnQuirofano
            // 
            this.btnQuirofano.BackColor = System.Drawing.Color.White;
            this.btnQuirofano.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuirofano.ForeColor = System.Drawing.Color.Blue;
            this.btnQuirofano.Location = new System.Drawing.Point(58, 231);
            this.btnQuirofano.Name = "btnQuirofano";
            this.btnQuirofano.Size = new System.Drawing.Size(580, 122);
            this.btnQuirofano.TabIndex = 8;
            this.btnQuirofano.Text = "Quirofano";
            this.btnQuirofano.UseVisualStyleBackColor = false;
            this.btnQuirofano.Click += new System.EventHandler(this.btnQuirofano_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(715, 682);
            this.Controls.Add(this.btnQuirofano);
            this.Controls.Add(this.btnEstadisticaHospital);
            this.Controls.Add(this.btnVerListado);
            this.Controls.Add(this.btnMenuCirujano);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnMenuCirujano;
        private System.Windows.Forms.Button btnVerListado;
        private System.Windows.Forms.Button btnEstadisticaHospital;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cirujanoToolStripMenuItem;
        private System.Windows.Forms.Button btnQuirofano;
    }
}

