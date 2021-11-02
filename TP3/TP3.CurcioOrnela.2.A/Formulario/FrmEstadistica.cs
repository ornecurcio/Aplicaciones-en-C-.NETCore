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
                foreach (Cirujano item in Hospital.Cirujanos)
                {
                    cmbTotalCirugias.Items.Add(item);
                    txtTotalCirugias.Visible = false;
                    txtCirugiaXPatologia.Visible = false;
                    txtCirugiaXProcedimiento.Visible = false; 
                }
            }
            else 
            {
                foreach (Paciente item in Hospital.Pacientes)
                {
                    cmbTotalCirugias.Items.Add(item);
                    txtTotalCirugias.Visible = false;
                    txtCirugiaXPatologia.Visible = false;
                    txtCirugiaXProcedimiento.Visible = false;
                }
            }
            if(servicio)
            {
                cmbTotalCirugias.Visible = false; 
                txtTotalCirugias.Visible = true;
                txtCirugiaXPatologia.Visible = true;
                txtCirugiaXProcedimiento.Visible = true;
                txtTotalCirugias.Text = Hospital.Cirugias.Count.ToString();
            }
            cmbCirugiaXPatologia.DataSource = Enum.GetValues(typeof(EPatologia));
            cmbCirugiaXProcedimiento.DataSource = Enum.GetValues(typeof(EProcedimiento));
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            FrmMostrarEstadistica mostrarEstadistica = new FrmMostrarEstadistica();
            mostrarEstadistica.ShowDialog(); 
        }
    }
}
