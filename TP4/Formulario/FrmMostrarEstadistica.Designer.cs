
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarEstadistica));
            this.dataEstadistica = new System.Windows.Forms.DataGridView();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnExportarAXml = new System.Windows.Forms.Button();
            this.btnExportarAJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEstadistica
            // 
            this.dataEstadistica.AllowUserToResizeColumns = false;
            this.dataEstadistica.AllowUserToResizeRows = false;
            this.dataEstadistica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEstadistica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEstadistica.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataEstadistica.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEstadistica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEstadistica.Location = new System.Drawing.Point(12, 51);
            this.dataEstadistica.Name = "dataEstadistica";
            this.dataEstadistica.RowHeadersVisible = false;
            this.dataEstadistica.RowTemplate.Height = 25;
            this.dataEstadistica.Size = new System.Drawing.Size(932, 412);
            this.dataEstadistica.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.Location = new System.Drawing.Point(12, 9);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(133, 24);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // btnExportarAXml
            // 
            this.btnExportarAXml.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportarAXml.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportarAXml.Location = new System.Drawing.Point(748, 469);
            this.btnExportarAXml.Name = "btnExportarAXml";
            this.btnExportarAXml.Size = new System.Drawing.Size(196, 28);
            this.btnExportarAXml.TabIndex = 2;
            this.btnExportarAXml.Text = "Exportar a Xml";
            this.btnExportarAXml.UseVisualStyleBackColor = false;
            this.btnExportarAXml.Click += new System.EventHandler(this.btnExportarAXml_Click);
            // 
            // btnExportarAJson
            // 
            this.btnExportarAJson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportarAJson.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportarAJson.Location = new System.Drawing.Point(526, 469);
            this.btnExportarAJson.Name = "btnExportarAJson";
            this.btnExportarAJson.Size = new System.Drawing.Size(196, 28);
            this.btnExportarAJson.TabIndex = 3;
            this.btnExportarAJson.Text = "Exportar a Json";
            this.btnExportarAJson.UseVisualStyleBackColor = false;
            this.btnExportarAJson.Click += new System.EventHandler(this.btnExportarAJson_Click);
            // 
            // FrmMostrarEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 501);
            this.Controls.Add(this.btnExportarAJson);
            this.Controls.Add(this.btnExportarAXml);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.dataEstadistica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmMostrarEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica";
            this.Load += new System.EventHandler(this.FrmMostrarEstadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEstadistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataEstadistica;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnExportarAXml;
        private System.Windows.Forms.Button btnExportarAJson;
    }
}