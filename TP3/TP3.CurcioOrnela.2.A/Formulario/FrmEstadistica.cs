using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades; 

namespace Formulario
{
    public partial class FrmEstadistica : Form
    {
        bool esMedico;
        bool servicio; 
        public FrmEstadistica()
        {
            InitializeComponent();
            
        }
        public FrmEstadistica(bool esMedico, bool servicio):this()
        {
            this.esMedico = esMedico;
            this.servicio = servicio; 
        }

        private void FrmEstadistica_Load(object sender, EventArgs e)
        {     
            if(esMedico)
            {
                cmbTotalCirugias.DataSource = null; 
                cmbTotalCirugias.DataSource = Hospital.Cirujanos;
                //foreach (Cirujano item in Hospital.Cirujanos)
                //{
                //    cmbTotalCirugias.Items.Add(item);
                    
                //}
                txtTotalCirugias.Visible = false;
                txtCirugiaXPatologia.Visible = false;
                txtCirugiaXProcedimiento.Visible = false;
            }
            //else 
            //{
            //    foreach (Paciente item in Hospital.Pacientes)
            //    {
            //        cmbTotalCirugias.Items.Add(item);
            //        txtTotalCirugias.Visible = false;
            //        txtCirugiaXPatologia.Visible = false;
            //        txtCirugiaXProcedimiento.Visible = false;
            //    }
            //}
            if(servicio)
            {
                cmbTotalCirugias.Visible = false; 
                txtTotalCirugias.Visible = true;
                txtCirugiaXPatologia.Visible = true;
                txtCirugiaXPatologia.Enabled = false; 
                txtCirugiaXProcedimiento.Visible = true;
                txtCirugiaXProcedimiento.Enabled = false; 
                txtTotalCirugias.Text = Hospital.Cirugias.Count.ToString();
                txtTotalCirugias.Enabled = false; 
            }
            cmbCirugiaXPatologia.DataSource = Enum.GetValues(typeof(EPatologia));
            cmbCirugiaXProcedimiento.DataSource = Enum.GetValues(typeof(EProcedimiento));
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            FrmMostrarEstadistica mostrarEstadistica = new FrmMostrarEstadistica();
            mostrarEstadistica.ShowDialog(); 
        }

        private void cmbCirugiaXPatologia_SelectedIndexChanged(object sender, EventArgs e)
        {
            EPatologia aux; 
            if (cmbCirugiaXPatologia.CanSelect && 
               Enum.TryParse(cmbCirugiaXPatologia.Text, out aux))
            {
                cmbCirugiaXProcedimiento.Enabled = false; 
                if(servicio)
                {
                    switch (aux)
                    {
                        case EPatologia.Columna:
                            txtCirugiaXPatologia.Text = Hospital.Estadistica.CantColumna.ToString();
                            break;
                        case EPatologia.MiembroSuperior:
                            txtCirugiaXPatologia.Text = Hospital.Estadistica.CantMiembroSuperior.ToString();
                            break;
                        case EPatologia.MiembroInferior:
                            txtCirugiaXPatologia.Text = Hospital.Estadistica.CantMiembroInferior.ToString();
                            break;
                        case EPatologia.Pelvis:
                            txtCirugiaXPatologia.Text = Hospital.Estadistica.CantPelvis.ToString();
                            break;
                    }
                }
                if(esMedico)
                {
                    switch (aux)
                    {
                        case EPatologia.Columna:
                            txtCirugiaXPatologia.Text = ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantColumna.ToString();  
                            break;
                        case EPatologia.MiembroSuperior:
                            txtCirugiaXPatologia.Text = ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantMiembroSuperior.ToString();
                            break;
                        case EPatologia.MiembroInferior:
                            txtCirugiaXPatologia.Text = ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantMiembroInferior.ToString();
                            break;
                        case EPatologia.Pelvis:
                            txtCirugiaXPatologia.Text = ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantPelvis.ToString();
                            break;
                    }
                    
                }
            }
        }
    }
}
