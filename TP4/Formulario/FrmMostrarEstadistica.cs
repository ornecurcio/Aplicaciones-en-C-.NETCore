using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades; 

namespace Formulario
{
    public partial class FrmMostrarEstadistica : Form
    {
        List<Cirugia> cirugias;
        public FrmMostrarEstadistica()
        {
            InitializeComponent();
            cirugias = new List<Cirugia>();
        }
        //Sobrecarga, se ingresa desde el hospital y se muestran todas las cirugias
        public FrmMostrarEstadistica(bool esServicio):this()
        {
            try
            {
                lblDescripcion.Text = "Cirugias Totales";
                if (esServicio)
                {
                    cirugias = Hospital.CirugiasRealizadas;
                }
            }
            catch(Exception ex)
            {
                ex.MostrarMensajeError(); 
            }
        }
        //Sobrecarga, se ingresa desde el hospital y se muestran las cirugias con esa patologia
        public FrmMostrarEstadistica(bool esServicio, EPatologia patologia) : this()
        {
            try
            {
                if (esServicio)
                {
                    lblDescripcion.Text = $"Cirugias de {patologia}";
                    cirugias = Hospital.CirugiasXPatologia(patologia);
                }
            }
            catch(Exception ex)
            {
                ex.MostrarMensajeError(); 
            }
        }
        //Sobrecarga, se ingresa desde el hospital y se muestran las cirugias con ese procedimiento
        public FrmMostrarEstadistica(bool esServicio, EProcedimiento procedimiento) : this()
        {
            try
            {
                lblDescripcion.Text = $"Cirugias de {procedimiento}";
                if (esServicio && Hospital.CirugiasRealizadas.Count > 0)
                {
                    cirugias = Hospital.CirugiasXProcedimiento(procedimiento);
                }
            }
            catch(Exception ex)
            {
                ex.MostrarMensajeError(); 
            }
        }
        private void FrmMostrarEstadistica_Load(object sender, EventArgs e)
        {
            this.Text = "Cirugias Realizadas"; 
            if (cirugias.Count > 0)
            {
                dataEstadistica.DataSource = null;
                dataEstadistica.DataSource = cirugias;
                dataEstadistica.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }
        //genera un archivo Json con los filtros aplicados
        private void btnExportarAJson_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = Archivo.GenerarRuta(lblDescripcion.Text + ".json");

                SerializacionAJason.SerializarAJason(ruta, cirugias);

                MessageBox.Show("Archivo generado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                ex.MostrarMensajeError(); 
            }
        }
        //Genera Archivo Xml con los filtros aplicados
        private void btnExportarAXml_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = Archivo.GenerarRuta(lblDescripcion.Text + ".xml");

                SerializacionAXml<List<Cirugia>>.SerializarAXmlLista(ruta, cirugias);

                MessageBox.Show("Archivo generado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                ex.MostrarMensajeError(); 
            }
        }
    }
}
