
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
            this.lblTotalCirugias = new System.Windows.Forms.Label();
            this.lblCirugiasXPatologia = new System.Windows.Forms.Label();
            this.lblCirugiaXProcedimiento = new System.Windows.Forms.Label();
            this.cmbTotalCirugias = new System.Windows.Forms.ComboBox();
            this.cmbCirugiaXProcedimiento = new System.Windows.Forms.ComboBox();
            this.cmbCirugiaXPatologia = new System.Windows.Forms.ComboBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.txtTotalCirugias = new System.Windows.Forms.TextBox();
            this.txtCirugiaXPatologia = new System.Windows.Forms.TextBox();
            this.txtCirugiaXProcedimiento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTotalCirugias
            // 
            this.lblTotalCirugias.AutoSize = true;
            this.lblTotalCirugias.Location = new System.Drawing.Point(63, 9);
            this.lblTotalCirugias.Name = "lblTotalCirugias";
            this.lblTotalCirugias.Size = new System.Drawing.Size(78, 15);
            this.lblTotalCirugias.TabIndex = 0;
            this.lblTotalCirugias.Text = "Total Cirugias";
            this.lblTotalCirugias.Click += new System.EventHandler(this.lblTotalCirugias_Click);
            // 
            // lblCirugiasXPatologia
            // 
            this.lblCirugiasXPatologia.AutoSize = true;
            this.lblCirugiasXPatologia.Location = new System.Drawing.Point(40, 145);
            this.lblCirugiasXPatologia.Name = "lblCirugiasXPatologia";
            this.lblCirugiasXPatologia.Size = new System.Drawing.Size(124, 15);
            this.lblCirugiasXPatologia.TabIndex = 1;
            this.lblCirugiasXPatologia.Text = "Cirugias por Patologia";
            this.lblCirugiasXPatologia.Click += new System.EventHandler(this.lblCirugiasXPatologia_Click);
            // 
            // lblCirugiaXProcedimiento
            // 
            this.lblCirugiaXProcedimiento.AutoSize = true;
            this.lblCirugiaXProcedimiento.Location = new System.Drawing.Point(30, 291);
            this.lblCirugiaXProcedimiento.Name = "lblCirugiaXProcedimiento";
            this.lblCirugiaXProcedimiento.Size = new System.Drawing.Size(147, 15);
            this.lblCirugiaXProcedimiento.TabIndex = 2;
            this.lblCirugiaXProcedimiento.Text = "Cirugia por Procedimiento";
            this.lblCirugiaXProcedimiento.Click += new System.EventHandler(this.lblCirugiaXProcedimiento_Click);
            // 
            // cmbTotalCirugias
            // 
            this.cmbTotalCirugias.FormattingEnabled = true;
            this.cmbTotalCirugias.Location = new System.Drawing.Point(40, 41);
            this.cmbTotalCirugias.Name = "cmbTotalCirugias";
            this.cmbTotalCirugias.Size = new System.Drawing.Size(205, 23);
            this.cmbTotalCirugias.TabIndex = 3;
            this.cmbTotalCirugias.SelectedIndexChanged += new System.EventHandler(this.cmbTotalCirugias_SelectedIndexChanged);
            // 
            // cmbCirugiaXProcedimiento
            // 
            this.cmbCirugiaXProcedimiento.FormattingEnabled = true;
            this.cmbCirugiaXProcedimiento.Location = new System.Drawing.Point(40, 332);
            this.cmbCirugiaXProcedimiento.Name = "cmbCirugiaXProcedimiento";
            this.cmbCirugiaXProcedimiento.Size = new System.Drawing.Size(205, 23);
            this.cmbCirugiaXProcedimiento.TabIndex = 4;
            this.cmbCirugiaXProcedimiento.SelectedIndexChanged += new System.EventHandler(this.cmbCirugiaXProcedimiento_SelectedIndexChanged);
            // 
            // cmbCirugiaXPatologia
            // 
            this.cmbCirugiaXPatologia.FormattingEnabled = true;
            this.cmbCirugiaXPatologia.Location = new System.Drawing.Point(40, 188);
            this.cmbCirugiaXPatologia.Name = "cmbCirugiaXPatologia";
            this.cmbCirugiaXPatologia.Size = new System.Drawing.Size(205, 23);
            this.cmbCirugiaXPatologia.TabIndex = 5;
            this.cmbCirugiaXPatologia.SelectedIndexChanged += new System.EventHandler(this.cmbCirugiaXPatologia_SelectedIndexChanged);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(184, 401);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // txtTotalCirugias
            // 
            this.txtTotalCirugias.Location = new System.Drawing.Point(43, 76);
            this.txtTotalCirugias.Name = "txtTotalCirugias";
            this.txtTotalCirugias.Size = new System.Drawing.Size(202, 23);
            this.txtTotalCirugias.TabIndex = 7;
            // 
            // txtCirugiaXPatologia
            // 
            this.txtCirugiaXPatologia.Location = new System.Drawing.Point(40, 217);
            this.txtCirugiaXPatologia.Name = "txtCirugiaXPatologia";
            this.txtCirugiaXPatologia.Size = new System.Drawing.Size(205, 23);
            this.txtCirugiaXPatologia.TabIndex = 8;
            // 
            // txtCirugiaXProcedimiento
            // 
            this.txtCirugiaXProcedimiento.Location = new System.Drawing.Point(40, 361);
            this.txtCirugiaXProcedimiento.Name = "txtCirugiaXProcedimiento";
            this.txtCirugiaXProcedimiento.Size = new System.Drawing.Size(205, 23);
            this.txtCirugiaXProcedimiento.TabIndex = 9;
            // 
            // FrmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 450);
            this.Controls.Add(this.txtCirugiaXProcedimiento);
            this.Controls.Add(this.txtCirugiaXPatologia);
            this.Controls.Add(this.txtTotalCirugias);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.cmbCirugiaXPatologia);
            this.Controls.Add(this.cmbCirugiaXProcedimiento);
            this.Controls.Add(this.cmbTotalCirugias);
            this.Controls.Add(this.lblCirugiaXProcedimiento);
            this.Controls.Add(this.lblCirugiasXPatologia);
            this.Controls.Add(this.lblTotalCirugias);
            this.Name = "FrmEstadistica";
            this.Text = "FrmEstadistica";
            this.Load += new System.EventHandler(this.FrmEstadistica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalCirugias;
        private System.Windows.Forms.Label lblCirugiasXPatologia;
        private System.Windows.Forms.Label lblCirugiaXProcedimiento;
        private System.Windows.Forms.ComboBox cmbTotalCirugias;
        private System.Windows.Forms.ComboBox cmbCirugiaXProcedimiento;
        private System.Windows.Forms.ComboBox cmbCirugiaXPatologia;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TextBox txtTotalCirugias;
        private System.Windows.Forms.TextBox txtCirugiaXPatologia;
        private System.Windows.Forms.TextBox txtCirugiaXProcedimiento;
    }
}