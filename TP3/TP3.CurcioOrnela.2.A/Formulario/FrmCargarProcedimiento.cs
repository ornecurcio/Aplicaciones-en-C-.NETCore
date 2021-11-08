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
    public partial class FrmCargarProcedimiento : Form, ICargarCmb
    {
        bool esMedico; 
        public FrmCargarProcedimiento()
        {
            InitializeComponent();
        }
        public FrmCargarProcedimiento(bool esMedico):this()
        {
            this.esMedico = esMedico; 
        }
        private void FrmCargarProcedimiento_Load(object sender, EventArgs e)
        {
            if (esMedico)
            {
                lblPersona.Text = "Cirujano";
                CargarCmbLista(cmbApellidoNombre, Hospital.Cirujanos); 
                lblPacientevsCirujano.Text = "Paciente";
                CargarCmbLista(cmbPacientevsCirujano, Hospital.Pacientes); 
                cmbPatologia.DataSource = Hospital.Pacientes[0].Patologia;
            }
            else
            {
                lblPersona.Text = "Paciente";
                CargarCmbLista(cmbApellidoNombre, Hospital.Pacientes);
                lblAgregarNuevo2.Visible = false;
                lblPacientevsCirujano.Visible = false;
                cmbPacientevsCirujano.Visible = false;
                lblProcedimiento.Visible = false;
                cmbProcedimiento.Visible = false;
                ActualizarCmbPatologia(Hospital.Pacientes[0]);
            }
            cmbProcedimiento.Enabled = false;
        }
        private void cmbApellidoNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!esMedico)
            {
                Paciente aux = (Paciente)cmbApellidoNombre.SelectedItem;
                ActualizarCmbPatologia(aux);
            }
        }
        private void cmbPatologia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProcedimiento.Enabled = true;
            if (cmbPatologia.CanSelect)
            {
                switch (cmbPatologia.Text)
                {
                    case "Columna":
                        cmbProcedimiento.Items.Clear(); 
                        cmbProcedimiento.Items.AddRange(new String[] { "RAFI", "Artrodecis", "Osteotomia", "Yeso" });
                        break;
                    case "MiembroSuperior":
                        cmbProcedimiento.Items.Clear();
                        cmbProcedimiento.Items.AddRange(new String[] { "RAFI", "Artrodecis", "Osteotomia", "Yeso", "ReduccionCerrada", "Osteodesis" });
                        break;
                    case "MiembroInferior":
                        cmbProcedimiento.Items.Clear();
                        cmbProcedimiento.Items.AddRange(new String[] { "RAFI", "Artrodecis", "Osteotomia", "Yeso", "ReduccionCerrada", "Osteodesis" });
                        break;
                    case "Pelvis":
                        cmbProcedimiento.Items.Clear();
                        cmbProcedimiento.Items.AddRange(new String[] { "Artrodecis", "Osteotomia", "Yeso" });
                        break;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(esMedico && cmbApellidoNombre.CanSelect && cmbPatologia.CanSelect 
               && cmbPacientevsCirujano.CanSelect && cmbProcedimiento.CanSelect)
            {
                Enum.TryParse(cmbPatologia.Text, out EPatologia auxP);
                Enum.TryParse(cmbProcedimiento.Text, out EProcedimiento auxPr);
                
                Cirugia aux = null; 

                aux = new Cirugia((Paciente)cmbPacientevsCirujano.SelectedItem, DateTime.Now, 
                                  (Cirujano)cmbApellidoNombre.SelectedItem, auxP, auxPr);
                ((Cirujano)cmbApellidoNombre.SelectedItem).Estadistica.ActualizarPatologia(auxP);
                ((Cirujano)cmbApellidoNombre.SelectedItem).Estadistica.ActualizarProcedimiento(auxPr);
                Hospital.CargarCirugia(aux);

                this.Close();
            }
            else if(!esMedico && cmbApellidoNombre.CanSelect && cmbPatologia.CanSelect && 
                     Enum.TryParse(cmbPatologia.Text, out EPatologia auxP))
            {
                Paciente aux = (Paciente)cmbApellidoNombre.SelectedItem;
                aux.Patologia.Add(auxP);
                Hospital.ActualizarPaciente(aux); 
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una opcion de cada casilla", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }  
        }
        private void lblAgregarNuevo_Click(object sender, EventArgs e)
        {
            FrmIngresoDatos ingresoDatos = new FrmIngresoDatos(esMedico);
            if(ingresoDatos.ShowDialog()==DialogResult.OK)
            {
                this.Close(); 
            }
        }
        private void lblAgregarNuevo2_Click(object sender, EventArgs e)
        {
            FrmIngresoDatos ingresoDatos = new FrmIngresoDatos(!esMedico);
            if (ingresoDatos.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void cmbPacientevsCirujano_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (esMedico)
            {
                Paciente aux = (Paciente)cmbPacientevsCirujano.SelectedItem;
                //CargarCmbLista(cmbPatologia, aux.Patologia); 
                cmbPatologia.DataSource = null;
                cmbPatologia.DataSource = aux.Patologia;
            }
        }
        private void ActualizarCmbPatologia(Paciente paciente)
        {
            List<EPatologia> diferente = new List<EPatologia>();
            foreach (EPatologia item in Enum.GetValues(typeof(EPatologia)))
            {
                if (!paciente.Patologia.Exists((x) => item == x))
                {
                    diferente.Add(item);
                }
            }
           // CargarCmbLista(cmbPatologia, diferente); 
            cmbPatologia.DataSource = null;
            cmbPatologia.DataSource = diferente;
        }

        public void CargarCmbLista<T>(ComboBox d, List<T> lista) where T : class
        {
            if (lista is not null && lista.Count > 0)
            {
                d.DataSource = lista;
            }
        }

        void ICargarCmb.CargarCmbEnum<T>(ComboBox d, T enu)
        {
            d.DataSource = Enum.GetValues(typeof(T));
        }
    }
}
