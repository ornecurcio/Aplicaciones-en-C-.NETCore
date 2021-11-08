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
    public partial class FrmEstadistica : Form, ICargarCmb
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
                this.LoadInicial();
                CargarCmbLista(cmbTotalCirugias, Hospital.Cirujanos);
                txtTotalCirugias.Visible = true;
            }
            else if (servicio)
            {
                this.LoadInicial();
                cmbTotalCirugias.Visible = false;
                txtTotalCirugias.Text = Hospital.Cirugias.Count.ToString();
                txtTotalCirugias.Enabled = false;
            }
            else
            {
                this.LoadPaciente();
                lblCirugiasXPatologia.Text = "Pacientes por Patologia";
            }
        }

        private void lblTotalCirugias_Click(object sender, EventArgs e)
        {
            cmbCirugiaXPatologia.Enabled = false;
            cmbCirugiaXProcedimiento.Enabled = false;
        }
        private void cmbTotalCirugias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTotalCirugias.CanSelect)
            {
                int aux = ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantColumna +
                 ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantMiembroSuperior +
                 ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantMiembroInferior +
                 ((Cirujano)cmbTotalCirugias.SelectedItem).Estadistica.CantPelvis;
                txtTotalCirugias.Text = aux.ToString();
            }
        }
        private void lblCirugiasXPatologia_Click(object sender, EventArgs e)
        {
            CargarCmbEnum<Type>(cmbCirugiaXPatologia, typeof(EPatologia));
            cmbCirugiaXPatologia.Enabled = true;
            cmbCirugiaXProcedimiento.Enabled = false;
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

        private void lblCirugiaXProcedimiento_Click(object sender, EventArgs e)
        {
            cmbCirugiaXProcedimiento.Enabled = true;
            cmbCirugiaXPatologia.Enabled = false;
            CargarCmbEnum<Type>(cmbCirugiaXProcedimiento, typeof(EProcedimiento));
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

        private void btnVer_Click(object sender, EventArgs e)
        {
            EProcedimiento auxPr;
            EPatologia auxP;
            if (servicio && !cmbTotalCirugias.Visible && !cmbCirugiaXPatologia.Enabled && !cmbCirugiaXProcedimiento.Enabled)
            {
                FrmMostrarEstadistica mostrarEstadistica = new FrmMostrarEstadistica(servicio);
                mostrarEstadistica.ShowDialog();
            }
            if (servicio && !cmbTotalCirugias.Visible && cmbCirugiaXPatologia.CanSelect && !cmbCirugiaXProcedimiento.Enabled
               && Enum.TryParse(cmbCirugiaXPatologia.Text, out auxP))
            {
                FrmMostrarEstadistica mostrarEstadistica = new FrmMostrarEstadistica(servicio, auxP);
                mostrarEstadistica.ShowDialog();
            }
            if (!cmbTotalCirugias.Visible && !cmbCirugiaXPatologia.Enabled && cmbCirugiaXProcedimiento.CanSelect
              //if(servicio
              && Enum.TryParse(cmbCirugiaXProcedimiento.Text, out auxPr))
            {
                FrmMostrarEstadistica mostrarEstadistica = new FrmMostrarEstadistica(servicio, auxPr);
                mostrarEstadistica.ShowDialog();
            }
            if (cmbTotalCirugias.CanSelect && !cmbCirugiaXPatologia.Enabled && !cmbCirugiaXProcedimiento.Enabled)
            {
                FrmMostrarEstadistica mostrarEstadistica = new FrmMostrarEstadistica((Cirujano)cmbTotalCirugias.SelectedItem);
                mostrarEstadistica.ShowDialog();
            }
            if (cmbTotalCirugias.CanSelect && cmbCirugiaXPatologia.CanSelect && Enum.TryParse(cmbCirugiaXPatologia.Text, out auxP))
            {
                FrmMostrarEstadistica mostrarEstadistica = new FrmMostrarEstadistica((Cirujano)cmbTotalCirugias.SelectedItem, auxP);
                mostrarEstadistica.ShowDialog();
            }
            if (cmbTotalCirugias.CanSelect && cmbCirugiaXProcedimiento.CanSelect && Enum.TryParse(cmbCirugiaXProcedimiento.Text, out auxPr))
            {
                FrmMostrarEstadistica mostrarEstadistica = new FrmMostrarEstadistica((Cirujano)cmbTotalCirugias.SelectedItem, auxPr);
                mostrarEstadistica.ShowDialog();
            }
            if (!esMedico && !servicio && cmbCirugiaXPatologia.CanSelect && Enum.TryParse(cmbCirugiaXPatologia.Text, out auxP))
            {
                FrmMostrarEstadistica mostrarEstadistica = new FrmMostrarEstadistica(auxP);
                mostrarEstadistica.ShowDialog();
            }
        }
        private void LoadPaciente()
        {
            cmbCirugiaXPatologia.Visible = true;
            cmbCirugiaXPatologia.Enabled = false;
            txtTotalCirugias.Visible = false;
            txtCirugiaXPatologia.Visible = false;
            txtCirugiaXProcedimiento.Visible = false;
            cmbTotalCirugias.Visible = false;
            lblTotalCirugias.Visible = false;
            lblCirugiaXProcedimiento.Visible = false;
            cmbCirugiaXProcedimiento.Visible = false;
        }
        private void LoadInicial()
        {
            cmbCirugiaXPatologia.Enabled = false;
            txtCirugiaXPatologia.Enabled = false;
            cmbCirugiaXProcedimiento.Enabled = false;
            txtCirugiaXProcedimiento.Enabled = false;
            cmbCirugiaXProcedimiento.DataSource = null;
            cmbCirugiaXPatologia.DataSource = null;
        }

        public void CargarCmbLista<T>(ComboBox d, List<T> lista) where T : class
        {
            if (lista is not null && lista.Count > 0)
            {
                d.DataSource = lista;
            }
        }

        public void CargarCmbEnum<T>(ComboBox d, T enu) where T : Type
        {
            d.DataSource = Enum.GetValues(enu);
        }
    }
}

