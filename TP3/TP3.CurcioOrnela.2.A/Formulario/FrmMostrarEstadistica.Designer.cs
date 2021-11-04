
namespace Formulario
{
    partial class FrmMostrarEstadistica
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
            this.dataEstadistica = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEstadistica
            // 
            this.dataEstadistica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEstadistica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataEstadistica.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEstadistica.Location = new System.Drawing.Point(12, 41);
            this.dataEstadistica.Name = "dataEstadistica";
            this.dataEstadistica.RowTemplate.Height = 25;
            this.dataEstadistica.Size = new System.Drawing.Size(776, 371);
            this.dataEstadistica.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(564, 418);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(196, 23);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar a Json";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // FrmMostrarEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataEstadistica);
            this.Name = "FrmMostrarEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMostrarEstadistica";
            this.Load += new System.EventHandler(this.FrmMostrarEstadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEstadistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataEstadistica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportar;
    }
}