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
    public partial class FrmCargarProcedimiento : Form
    {
        bool esMedico; 
        public FrmCargarProcedimiento()
        {
            InitializeComponent();
        }
        public FrmCargarProcedimiento(bool esMedico)
        {
            this.esMedico = esMedico; 
        }

        private void FrmCargarProcedimiento_Load(object sender, EventArgs e)
        {
            if(esMedico)
            {
                lblPersona.Text = "Cirujano";
                lblRol.Text = "Rol"; 
                cmbRol.DataSource = Enum.GetValues(typeof(ERol));
                
            }
            else
            {
                lblPersona.Text = "Paciente";
                lblRol.Visible = false;
                cmbRol.Visible = false; 
            }
            cmbPatologia.DataSource = Enum.GetValues(typeof(EPatologia));
            cmbProcedimiento.Enabled = false;

        }

        
    }
}
