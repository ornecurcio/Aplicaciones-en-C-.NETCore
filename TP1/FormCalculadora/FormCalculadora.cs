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

namespace FormCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.SelectedIndex = 0;
        }
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operador1 = new Operando(numero1);
            Operando operador2 = new Operando(numero2);
            char.TryParse(operador, out char auxOperador);
            return Calculadora.Operar(operador1, operador2, auxOperador);
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro desea salir?", "Salir", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            lstOperaciones.Items.Add(txtNumero1.Text + cmbOperador.Text + 
                                     txtNumero2.Text + "=" + resultado.ToString());
            lblResultado.Text = resultado.ToString();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando numero = new Operando();
            lblResultado.Text = numero.DecimalBinario(lblResultado.Text);
        }
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando numero = new Operando();
            lblResultado.Text = numero.BinarioDecimal(lblResultado.Text);   
        }
    }
}
