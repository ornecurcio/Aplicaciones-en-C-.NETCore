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
        public FrmCargarProcedimiento(bool esMedico):this()
        {
            this.esMedico = esMedico; 
        }

        private void FrmCargarProcedimiento_Load(object sender, EventArgs e)
        {
            if(esMedico)
            {
                lblPersona.Text = "Cirujano";
                foreach (Cirujano item in Hospital.Cirujanos)
                {
                    cmbApellidoNombre.Items.Add(item);
                }
                lblPacientevsCirujano.Text = "Paciente";
                foreach (Paciente item in Hospital.Pacientes)
                {
                    //cmbApellidoNombre.Items.Add(new { Text = item.Apellido + ", " + item.Nombre });
                    cmbPacientevsCirujano.Items.Add(item);
                }
            }
            else
            {
                lblPersona.Text = "Paciente";
                foreach (Paciente item in Hospital.Pacientes)
                {
                    //cmbApellidoNombre.Items.Add(new { Text = item.Apellido + ", " + item.Nombre });
                    cmbApellidoNombre.Items.Add(item);
                }

                lblPacientevsCirujano.Text = "Cirujano";
                foreach (Cirujano item in Hospital.Cirujanos)
                {
                    cmbPacientevsCirujano.Items.Add(item); 
                }
                
            }
            cmbPatologia.DataSource = Enum.GetValues(typeof(EPatologia));
            cmbProcedimiento.Enabled = false;

        }

        private void cmbPatologia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProcedimiento.Enabled = true;
            if (cmbPatologia.CanSelect)
            {
                //switch (cmbApellidoNombre.SelectedItem.ToString()) //TIRA UNA EXCEPTION 
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
                        cmbProcedimiento.Items.AddRange(new String[] { "Artrodecis", "Osteotomia", "Yeso" });
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(esMedico && cmbApellidoNombre.CanSelect && cmbPatologia.CanSelect 
                        && cmbPacientevsCirujano.CanSelect && cmbProcedimiento.CanSelect)
            {
                Cirugia aux = new Cirugia((Paciente)cmbApellidoNombre.SelectedItem, new Estadistica(), DateTime.Now, (Cirujano)cmbPacientevsCirujano.SelectedItem, 
                //Hospital.Cirugias.Add(aux); 
                //this.Close(); 
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
            ingresoDatos.ShowDialog();
        }
    }
}
