
namespace Formulario
{
    partial class FrmEstadistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadistica));
            this.lblTotalCirugias = new System.Windows.Forms.Label();
            this.cmbCirugiaXProcedimiento = new System.Windows.Forms.ComboBox();
            this.cmbCirugiaXPatologia = new System.Windows.Forms.ComboBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.txtTotalCirugias = new System.Windows.Forms.TextBox();
            this.txtCirugiaXPatologia = new System.Windows.Forms.TextBox();
            this.txtCirugiaXProcedimiento = new System.Windows.Forms.TextBox();
            this.btnPatologias = new System.Windows.Forms.Button();
            this.btnProcedimientos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalCirugias
            // 
            this.lblTotalCirugias.AutoSize = true;
            this.lblTotalCirugias.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCirugias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTotalCirugias.Location = new System.Drawing.Point(51, 9);
            this.lblTotalCirugias.Name = "lblTotalCirugias";
            this.lblTotalCirugias.Size = new System.Drawing.Size(179, 32);
            this.lblTotalCirugias.TabIndex = 0;
            this.lblTotalCirugias.Text = "Total Cirugias";
            
            // 
            // cmbCirugiaXProcedimiento
            // 
            this.cmbCirugiaXProcedimiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCirugiaXProcedimiento.FormattingEnabled = true;
            this.cmbCirugiaXProcedimiento.Location = new System.Drawing.Point(30, 279);
            this.cmbCirugiaXProcedimiento.Name = "cmbCirugiaXProcedimiento";
            this.cmbCirugiaXProcedimiento.Size = new System.Drawing.Size(215, 28);
            this.cmbCirugiaXProcedimiento.TabIndex = 4;
            this.cmbCirugiaXProcedimiento.SelectedIndexChanged += new System.EventHandler(this.cmbCirugiaXProcedimiento_SelectedIndexChanged);
            // 
            // cmbCirugiaXPatologia
            // 
            this.cmbCirugiaXPatologia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCirugiaXPatologia.FormattingEnabled = true;
            this.cmbCirugiaXPatologia.Location = new System.Drawing.Point(30, 157);
            this.cmbCirugiaXPatologia.Name = "cmbCirugiaXPatologia";
            this.cmbCirugiaXPatologia.Size = new System.Drawing.Size(215, 28);
            this.cmbCirugiaXPatologia.TabIndex = 5;
            this.cmbCirugiaXPatologia.SelectedIndexChanged += new System.EventHandler(this.cmbCirugiaXPatologia_SelectedIndexChanged);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVer.Location = new System.Drawing.Point(155, 356);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(90, 37);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // txtTotalCirugias
            // 
            this.txtTotalCirugias.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalCirugias.Location = new System.Drawing.Point(30, 58);
            this.txtTotalCirugias.Name = "txtTotalCirugias";
            this.txtTotalCirugias.Size = new System.Drawing.Size(215, 33);
            this.txtTotalCirugias.TabIndex = 7;
            // 
            // txtCirugiaXPatologia
            // 
            this.txtCirugiaXPatologia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCirugiaXPatologia.Location = new System.Drawing.Point(30, 191);
            this.txtCirugiaXPatologia.Name = "txtCirugiaXPatologia";
            this.txtCirugiaXPatologia.Size = new System.Drawing.Size(215, 27);
            this.txtCirugiaXPatologia.TabIndex = 8;
            // 
            // txtCirugiaXProcedimiento
            // 
            this.txtCirugiaXProcedimiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCirugiaXProcedimiento.Location = new System.Drawing.Point(30, 313);
            this.txtCirugiaXProcedimiento.Name = "txtCirugiaXProcedimiento";
            this.txtCirugiaXProcedimiento.Size = new System.Drawing.Size(215, 27);
            this.txtCirugiaXProcedimiento.TabIndex = 9;
            // 
            // btnPatologias
            // 
            this.btnPatologias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPatologias.Location = new System.Drawing.Point(30, 115);
            this.btnPatologias.Name = "btnPatologias";
            this.btnPatologias.Size = new System.Drawing.Size(215, 36);
            this.btnPatologias.TabIndex = 10;
            this.btnPatologias.Text = "Patologias";
            this.btnPatologias.UseVisualStyleBackColor = true;
            this.btnPatologias.Click += new System.EventHandler(this.btnPatologias_Click);
            // 
            // btnProcedimientos
            // 
            this.btnProcedimientos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcedimientos.Location = new System.Drawing.Point(29, 235);
            this.btnProcedimientos.Name = "btnProcedimientos";
            this.btnProcedimientos.Size = new System.Drawing.Size(216, 38);
            this.btnProcedimientos.TabIndex = 11;
            this.btnProcedimientos.Text = "Procedimientos";
            this.btnProcedimientos.UseVisualStyleBackColor = true;
            this.btnProcedimientos.Click += new System.EventHandler(this.btnProcedimientos_Click);
            // 
            // FrmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(281, 414);
            this.Controls.Add(this.btnProcedimientos);
            this.Controls.Add(this.btnPatologias);
            this.Controls.Add(this.txtCirugiaXProcedimiento);
            this.Controls.Add(this.txtCirugiaXPatologia);
            this.Controls.Add(this.txtTotalCirugias);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.cmbCirugiaXPatologia);
            this.Controls.Add(this.cmbCirugiaXProcedimiento);
            this.Controls.Add(this.lblTotalCirugias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmEstadistica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalCirugias;
        private System.Windows.Forms.ComboBox cmbCirugiaXProcedimiento;
        private System.Windows.Forms.ComboBox cmbCirugiaXPatologia;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TextBox txtTotalCirugias;
        private System.Windows.Forms.TextBox txtCirugiaXPatologia;
        private System.Windows.Forms.TextBox txtCirugiaXProcedimiento;
        private System.Windows.Forms.Button btnPatologias;
        private System.Windows.Forms.Button btnProcedimientos;
    }
}