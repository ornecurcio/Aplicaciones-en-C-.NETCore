
namespace Formulario
{
    partial class FrmEstadisticaHospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticaHospital));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.rchInfoHospital = new System.Windows.Forms.RichTextBox();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(26, 19);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(309, 32);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Estadisticas generales";
            // 
            // rchInfoHospital
            // 
            this.rchInfoHospital.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchInfoHospital.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rchInfoHospital.Location = new System.Drawing.Point(26, 54);
            this.rchInfoHospital.Name = "rchInfoHospital";
            this.rchInfoHospital.Size = new System.Drawing.Size(753, 416);
            this.rchInfoHospital.TabIndex = 1;
            this.rchInfoHospital.Text = "";
            // 
            // btnArchivo
            // 
            this.btnArchivo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnArchivo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnArchivo.Location = new System.Drawing.Point(580, 480);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(199, 23);
            this.btnArchivo.TabIndex = 2;
            this.btnArchivo.Text = "Guardar en Archivo.txt";
            this.btnArchivo.UseVisualStyleBackColor = false;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // FrmEstadisticaHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(805, 515);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.rchInfoHospital);
            this.Controls.Add(this.lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstadisticaHospital";
            this.Text = "FrmEstadisticaHospital";
            this.Load += new System.EventHandler(this.FrmEstadisticaHospital_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.RichTextBox rchInfoHospital;
        private System.Windows.Forms.Button btnArchivo;
    }
}