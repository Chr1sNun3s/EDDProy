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
    public partial class frmQuickSort : Form
    {
        public frmQuickSort()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                int[] array = txtDato.Text.Split(',', ' ')
                                           .Select(int.Parse)
                                           .ToArray();
                QuickSort.Sort(array, 0, array.Length - 1);
                txtSalida.Text = string.Join(", ", array);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
