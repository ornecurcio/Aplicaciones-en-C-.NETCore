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
        public FrmEstadistica(bool esMedico, bool servicio) : this()
        {
            this.esMedico = esMedico;
            this.servicio = servicio;
        }

        private void FrmEstadistica_Load(object sender, EventArgs e)
        {
            if (esMedico)
            {
                cmbTotalCirugias.DataSource = null;
                cmbTotalCirugias.DataSource = Hospital.Cirujanos;
                txtTotalCirugias.Visible = true;
                txtCirugiaXPatologia.Enabled = false;
                txtCirugiaXProcedimiento.Enabled = false;
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
            if (servicio)
            {
                cmbTotalCirugias.Visible = false;
                txtCirugiaXPatologia.Enabled = false;
                txtCirugiaXProcedimiento.Enabled = false;
                txtTotalCirugias.Text = Hospital.Cirugias.Count.ToString();
                txtTotalCirugias.Enabled = false;
            }
            cmbCirugiaXPatologia.DataSource = Enum.GetValues(typeof(EPatologia));
            cmbCirugiaXProcedimiento.DataSource = Enum.GetValues(typeof(EProcedimiento));
            cmbCirugiaXPatologia.Enabled = false;
            cmbCirugiaXProcedimiento.Enabled = false;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            FrmMostrarEstadistica mostrarEstadistica = new FrmMostrarEstadistica(servicio);
            mostrarEstadistica.ShowDialog();
        }

        private void cmbCirugiaXPatologia_SelectedIndexChanged(object sender, EventArgs e)
        {
            EPatologia aux;
            if (cmbCirugiaXPatologia.CanSelect &&
               Enum.TryParse(cmbCirugiaXPatologia.Text, out aux))
            {
                cmbCirugiaXProcedimiento.Enabled = false;
                if (servicio)
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
                if (esMedico)
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

        private void lblCirugiasXPatologia_Click(object sender, EventArgs e)
        {
            cmbCirugiaXPatologia.Enabled = true;
            cmbCirugiaXProcedimiento.Enabled = false;
        }

        private void lblCirugiaXProcedimiento_Click(object sender, EventArgs e)
        {
            cmbCirugiaXProcedimiento.Enabled = true;
            cmbCirugiaXPatologia.Enabled = false; 
        }

        private void cmbCirugiaXProcedimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            EProcedimiento aux;
            if (cmbCirugiaXProcedimiento.CanSelect &&
               Enum.TryParse(cmbCirugiaXProcedimiento.Text, out aux))
            {
                cmbCirugiaXPatologia.Enabled = false;
                if (servicio)
                {
                    switch (aux)
                    {
                        case EProcedimiento.Artrodecis:
                            txtCirugiaXProcedimiento.Text = Hospital.Estadistica.CantArtrodecis.ToString();
                            break;
                        case EProcedimiento.Osteodesis:
                            txtCirugiaXProcedimiento.Text = Hospital.Estadistica.CantOsteodesis.ToString();
                            break;
                        case EProcedimiento.Osteotomia:
                            txtCirugiaXProcedimiento.Text = Hospital.Estadistica.CantOsteotomia.ToString();
                            break;
                        case EProcedimiento.RAFI:
                            txtCirugiaXProcedimiento.Text = Hospital.Estadistica.CantRAFI.ToString();
                            break;
                        case EProcedimiento.ReduccionCerrada:
                            txtCirugiaXProcedimiento.Text = Hospital.Estadistica.CantReduccionCerrada.ToString();
                            break;
                        case EProcedimiento.Yeso:
                            txtCirugiaXProcedimiento.Text = Hospital.Estadistica.CantYeso.ToString();
                            break;
                    }
                }
                if (esMedico)
                {
                    switch (aux)
                    {
                        case EProcedimiento.Artrodecis:
                            txtCirugiaXProcedimiento.Text = ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantArtrodecis.ToString();
                            break;
                        case EProcedimiento.Osteodesis:
                            txtCirugiaXProcedimiento.Text = ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantOsteodesis.ToString();
                            break;
                        case EProcedimiento.Osteotomia:
                            txtCirugiaXProcedimiento.Text = ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantOsteotomia.ToString();
                            break;
                        case EProcedimiento.RAFI:
                            txtCirugiaXProcedimiento.Text = ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantRAFI.ToString();
                            break;
                        case EProcedimiento.ReduccionCerrada:
                            txtCirugiaXProcedimiento.Text = ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantReduccionCerrada.ToString();
                            break;
                        case EProcedimiento.Yeso:
                            txtCirugiaXProcedimiento.Text = ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantYeso.ToString();
                            break;
                    }

                }
            }
        }

        private void cmbTotalCirugias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTotalCirugias.CanSelect)
            {
                //int aux = ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantColumna)  +
                //          ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantMiembroSuperior) +
                //          ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantMiembroInferior) +
                //          ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantPelvis);
                txtTotalCirugias.Text = "0";// aux.ToString(); 
            }
        }
    }
}
