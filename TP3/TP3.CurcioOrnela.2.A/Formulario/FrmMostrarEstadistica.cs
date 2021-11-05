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
    public partial class FrmMostrarEstadistica : Form
    {
        List<Cirugia> cirugias = new List<Cirugia>(); 
        public FrmMostrarEstadistica()
        {
            InitializeComponent();
        }
        public FrmMostrarEstadistica(bool esServicio):this()
        {
            lblDescripcion.Text = "Cirugias Totales";
            if (esServicio)
            {
                cirugias = Hospital.Cirugias;
            } 
        }
        public FrmMostrarEstadistica(bool esServicio, EPatologia patologia) : this()
        {
            lblDescripcion.Text = $"Cirugias de {patologia}"; 
            if (esServicio)
            {
                cirugias = Hospital.CirugiasXPatologia(patologia);
            }
        }
        public FrmMostrarEstadistica(bool esServicio, EProcedimiento procedimiento) : this()
        {
            lblDescripcion.Text = $"Cirugias de {procedimiento}";
            if (esServicio && Hospital.Cirugias.Count > 0)
            {
                cirugias = Hospital.CirugiasXProcedimiento(procedimiento);
            }
        }
        public FrmMostrarEstadistica(Cirujano cirujano, EPatologia patologia) : this()
        {
            lblDescripcion.Text = $"Cirugias de {cirujano} de {patologia}";
            cirugias = Hospital.CirugiasXPatologiaYCirujano(patologia,cirujano);

        }
        public FrmMostrarEstadistica(Cirujano cirujano, EProcedimiento procedimiento) : this()
        {
            lblDescripcion.Text = $"Cirugias de {cirujano} de {procedimiento}";
            cirugias = Hospital.CirugiasXProcedimientoYCirujano(procedimiento, cirujano);
        }
        private void FrmMostrarEstadistica_Load(object sender, EventArgs e)
        {
            if (cirugias.Count > 0)
            {
                dataEstadistica.DataSource = null;
                dataEstadistica.DataSource = cirugias;
                dataEstadistica.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string ruta = Serializacion.GenerarRuta(lblDescripcion.Text);
            Serializacion.SerializarAJason(ruta, cirugias); 
        }
    }
}
