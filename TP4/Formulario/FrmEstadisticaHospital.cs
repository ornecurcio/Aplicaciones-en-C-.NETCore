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
    public partial class FrmEstadisticaHospital : Form
    {
        public FrmEstadisticaHospital()
        {
            InitializeComponent();
        }

        private void FrmEstadisticaHospital_Load(object sender, EventArgs e)
        {
            this.Text = "Servicio de Ortopedia y Traumatologia"; 
            this.rchInfoHospital.Text += Hospital.CargarInfoPacientes();
            this.rchInfoHospital.Text += Hospital.CargarInfoCirujanos();
            this.rchInfoHospital.Text += Hospital.CargarPatologiaPrevalente();
            this.rchInfoHospital.Text += Hospital.CargarProcedimientoPrevalente();
            this.rchInfoHospital.Text += Hospital.PocentajeCirugiasCadaMedico(); 
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {try
            {
                string ruta = Archivo.GenerarRuta($"{DateTime.Today.ToString("dd-MM-yyyy")} Estadistica de Ortopedia y Traumatologia");
                Archivo.EscribirNuevoTxt(ruta, this.rchInfoHospital.Text);
                MessageBox.Show("Archivo generado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex) 
            { 
                ex.MostrarMensajeError(); 
            }
        }
    }
}
