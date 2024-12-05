using EDDemo.Algoritmos_de_ordenamiento.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Algoritmos_de_ordenamiento
{
    public partial class frmBurbuja : Form
    {
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {        
                int[] array = txtDato.Text.Split(',', ' ')
                                           .Select(int.Parse)
                                           .ToArray();            
                Burbuja.Ordenar(array);          
                txtResultado.Text = string.Join(", ", array);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
