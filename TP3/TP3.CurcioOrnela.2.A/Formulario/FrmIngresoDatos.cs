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
    public partial class FrmIngresoDatos : Form
    {
        bool esCirujano; 
        public FrmIngresoDatos()
        {
            InitializeComponent();
        }
        public FrmIngresoDatos(bool esCirujano):this()
        {
            this.esCirujano = esCirujano; 
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtApellido.Text) && !string.IsNullOrWhiteSpace(txtNombre.Text) 
                && txtApellido.Text.All(char.IsLetter) && txtNombre.Text.All(char.IsLetter) 
                && txtDni.Text.All(char.IsDigit) && !string.IsNullOrWhiteSpace(cmbRolPatologia.Text))
            {
                 if(esCirujano && Enum.TryParse(cmbRolPatologia.Text, out ERol auxR))
                 {
                    Hospital.CargarCirujanos(new Cirujano(txtNombre.Text, txtApellido.Text, double.Parse(txtDni.Text), auxR)); 
                 }
                 else if(Enum.TryParse(cmbRolPatologia.Text, out EPatologia auxP)) 
                 {
                    Hospital.CargarPacientes(new Paciente(txtNombre.Text, txtApellido.Text, double.Parse(txtDni.Text), auxP)); 
                 }
            }
            else
            {
                MessageBox.Show("Chequee datos ingresados", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void FrmIngresoDatos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro desea salir?", "Salir", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void FrmIngresoDatos_Load(object sender, EventArgs e)
        {
            if (esCirujano)
            {
                lblPersona.Text = "CIRUJANO";
                lblRolPatologia.Text = "Rol";
                cmbRolPatologia.DataSource = Enum.GetValues(typeof(ERol));
                esCirujano = true;
            }
            else
            {
                lblPersona.Text = "PACIENTE";
                lblRolPatologia.Text = "Patologia";
                cmbRolPatologia.DataSource = Enum.GetValues(typeof(EPatologia));
            }
        }
    }
}
