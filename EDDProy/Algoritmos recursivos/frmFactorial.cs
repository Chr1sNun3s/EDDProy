using EDDemo.Algoritmos_recursivos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Algoritmos_recursivos
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Factorial.ResetOperaciones(); 
                int numero = int.Parse(txtNumero.Text); 
                var resultado = Factorial.Calcular(numero);
                lblResultado.Text = $"Factorial: {resultado}"; 
                lblOperaciones.Text = $"Operaciones: {Factorial.Operaciones}"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void lblOperaciones_Click(object sender, EventArgs e)
        {

        }
    }   
}
