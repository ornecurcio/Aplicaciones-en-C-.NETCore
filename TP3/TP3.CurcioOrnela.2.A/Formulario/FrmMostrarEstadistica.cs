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
        bool esServicio;
        EPatologia patologia;
        EProcedimiento procedimiento;
        Cirujano cirujano = null; 

        public FrmMostrarEstadistica()
        {
            InitializeComponent();
        }
        public FrmMostrarEstadistica(bool esServicio):this()
        {
            this.esServicio = esServicio; 
        }
        public FrmMostrarEstadistica(bool esServicio, EPatologia patologia) : this()
        {
            this.esServicio = esServicio;
            this.patologia = patologia; 
        }
        public FrmMostrarEstadistica(bool esServicio, EProcedimiento procedimiento) : this()
        {
            this.esServicio = esServicio;
            this.procedimiento = procedimiento;
        }
        public FrmMostrarEstadistica(Cirujano cirujano, EPatologia patologia) : this()
        {
            this.cirujano = cirujano;
            this.patologia = patologia;
        }
        public FrmMostrarEstadistica(Cirujano cirujano, EProcedimiento procedimiento) : this()
        {
            this.cirujano = cirujano;
            this.procedimiento = procedimiento;
        }

        private void FrmMostrarEstadistica_Load(object sender, EventArgs e)
        {
            if(esServicio && Hospital.Cirugias.Count>0)
            {
                dataEstadistica.DataSource = null;
                dataEstadistica.DataSource = Hospital.Cirugias;
                dataEstadistica.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

       
    }
}
