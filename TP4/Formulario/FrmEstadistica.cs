using System;
using System.Collections.Generic;
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
        //Se carga formulario dependiendo si se ingresa para ver estadistica de el Hospital,
        //el medico, o patologias de los pacientes
        private void FrmEstadistica_Load(object sender, EventArgs e)
        {
            if (servicio)
            {
                this.LoadInicial();
                txtTotalCirugias.Text = Hospital.CirugiasRealizadas.Count.ToString();
                txtTotalCirugias.Enabled = false;
            }
        }
        //Al cliquear se habilita el cmb para seleccionar patologia
        private void btnPatologias_Click(object sender, EventArgs e)
        {
            CargarCmbEnum<Type>(cmbCirugiaXPatologia, typeof(EPatologia));
            cmbCirugiaXPatologia.Enabled = true;
            cmbCirugiaXProcedimiento.Enabled = false;
        }

        //Al seleccion una patologia se carga la cantidad de cirugias de esa patologia
        //(totales en el hospital)
        private void cmbCirugiaXPatologia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
                }
            }
            catch(Exception ex)
            {
                ex.MostrarMensajeError(); 
            }
        }
        //Al clickear se habilita un cmb para elegir procedimiento
        private void btnProcedimientos_Click(object sender, EventArgs e)
        {
            cmbCirugiaXProcedimiento.Enabled = true;
            cmbCirugiaXPatologia.Enabled = false;
            CargarCmbEnum<Type>(cmbCirugiaXProcedimiento, typeof(EProcedimiento));
        }

        //Al seleccionar un procedimiento se muestra la cantidad de los mismos 
        private void cmbCirugiaXProcedimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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

                }
            }
            catch(Exception ex)
            {
                ex.MostrarMensajeError(); 
            }
        }
        //Genera el llamado a un nuevo formulario que mostrara los listados de las cosas
        //dependiendo de si se muestra la estadistica del cirujano o del hospital o los pacientes
        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                EProcedimiento auxPr;
                EPatologia auxP;
                if (servicio && !cmbCirugiaXPatologia.Enabled && !cmbCirugiaXProcedimiento.Enabled)
                {
                    FrmMostrarEstadistica mostrarEstadistica = new FrmMostrarEstadistica(servicio);
                    mostrarEstadistica.ShowDialog();
                }
                if (servicio && cmbCirugiaXPatologia.CanSelect && !cmbCirugiaXProcedimiento.Enabled
                   && Enum.TryParse(cmbCirugiaXPatologia.Text, out auxP))
                {
                    FrmMostrarEstadistica mostrarEstadistica = new FrmMostrarEstadistica(servicio, auxP);
                    mostrarEstadistica.ShowDialog();
                }
                if (!cmbCirugiaXPatologia.Enabled && cmbCirugiaXProcedimiento.CanSelect
                  //if(servicio
                  && Enum.TryParse(cmbCirugiaXProcedimiento.Text, out auxPr))
                {
                    FrmMostrarEstadistica mostrarEstadistica = new FrmMostrarEstadistica(servicio, auxPr);
                    mostrarEstadistica.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                ex.MostrarMensajeError(); 
            }
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
        //Aplicacion de interfase, se cargan los cmb en bese a lo que se necesita
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

