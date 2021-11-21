
namespace Formulario
{
    partial class FrmQuirofano
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
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.btnRealizarCirugias = new System.Windows.Forms.Button();
            this.btnDetenerQuirofano = new System.Windows.Forms.Button();
            this.btnCerrarQuirofano = new System.Windows.Forms.Button();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 15;
            this.lstPacientes.Location = new System.Drawing.Point(25, 44);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(472, 304);
            this.lstPacientes.TabIndex = 0;
            // 
            // btnRealizarCirugias
            // 
            this.btnRealizarCirugias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRealizarCirugias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRealizarCirugias.Location = new System.Drawing.Point(535, 44);
            this.btnRealizarCirugias.Name = "btnRealizarCirugias";
            this.btnRealizarCirugias.Size = new System.Drawing.Size(234, 87);
            this.btnRealizarCirugias.TabIndex = 1;
            this.btnRealizarCirugias.Text = "Realizar Cirugias";
            this.btnRealizarCirugias.UseVisualStyleBackColor = false;
            this.btnRealizarCirugias.Click += new System.EventHandler(this.btnRealizarCirugias_Click);
            // 
            // btnDetenerQuirofano
            // 
            this.btnDetenerQuirofano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDetenerQuirofano.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDetenerQuirofano.Location = new System.Drawing.Point(535, 153);
            this.btnDetenerQuirofano.Name = "btnDetenerQuirofano";
            this.btnDetenerQuirofano.Size = new System.Drawing.Size(234, 90);
            this.btnDetenerQuirofano.TabIndex = 2;
            this.btnDetenerQuirofano.Text = "Detener Quirofano";
            this.btnDetenerQuirofano.UseVisualStyleBackColor = false;
            this.btnDetenerQuirofano.Click += new System.EventHandler(this.btnDetenerQuirofano_Click);
            // 
            // btnCerrarQuirofano
            // 
            this.btnCerrarQuirofano.BackColor = System.Drawing.Color.Red;
            this.btnCerrarQuirofano.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarQuirofano.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrarQuirofano.Location = new System.Drawing.Point(535, 267);
            this.btnCerrarQuirofano.Name = "btnCerrarQuirofano";
            this.btnCerrarQuirofano.Size = new System.Drawing.Size(234, 90);
            this.btnCerrarQuirofano.TabIndex = 3;
            this.btnCerrarQuirofano.Text = "Cerrar Quirofano";
            this.btnCerrarQuirofano.UseVisualStyleBackColor = false;
            this.btnCerrarQuirofano.Click += new System.EventHandler(this.btnCerrarQuirofano_Click);
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPacientes.Location = new System.Drawing.Point(25, 9);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(109, 24);
            this.lblPacientes.TabIndex = 4;
            this.lblPacientes.Text = "Pacientes";
            // 
            // FrmQuirofano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.btnCerrarQuirofano);
            this.Controls.Add(this.btnDetenerQuirofano);
            this.Controls.Add(this.btnRealizarCirugias);
            this.Controls.Add(this.lstPacientes);
            this.MaximizeBox = false;
            this.Name = "FrmQuirofano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuirofano";
            this.Load += new System.EventHandler(this.FrmQuirofano_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Button btnRealizarCirugias;
        private System.Windows.Forms.Button btnDetenerQuirofano;
        private System.Windows.Forms.Button btnCerrarQuirofano;
        private System.Windows.Forms.Label lblPacientes;
    }
}