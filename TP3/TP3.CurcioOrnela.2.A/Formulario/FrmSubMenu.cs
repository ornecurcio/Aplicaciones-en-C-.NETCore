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
    public partial class FrmSubMenu : Form
    {
        bool esMedico; 
        public FrmSubMenu()
        {
            InitializeComponent();
        }
        public FrmSubMenu(bool esMedico) : this()
        {
            this.esMedico = esMedico; 
        }

        private void FrmSubMenu_Load(object sender, EventArgs e)
        {

            if (esMedico)
            {
                btnAgregar.Text = "Agregar 1 cirugia a Cirujano";
                btnVer.Text = "Ver estadistica de 1 Cirujano";
            }
            else
            {
                btnAgregar.Text = "Agregar patologia a Paciente";
                btnVer.Text = "Ver Historial de 1 Paciente";
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCargarProcedimiento cargarProcedimiento = new FrmCargarProcedimiento(esMedico);
            cargarProcedimiento.ShowDialog(); 
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            FrmEstadistica estadistica = new FrmEstadistica(esMedico, false);
            estadistica.ShowDialog(); 
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            FrmIngresoDatos ingresoDatos = new FrmIngresoDatos(esMedico);
            ingresoDatos.ShowDialog(); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
