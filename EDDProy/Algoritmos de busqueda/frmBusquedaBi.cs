using EDDemo.Algoritmos_de_busqueda.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Algoritmos_de_busqueda
{
    public partial class frmBusquedaBi : Form
    {
        public frmBusquedaBi()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arreglo = txtArreglo.Text.Split(',', ' ')
                                               .Select(int.Parse)
                                               .ToArray();         
                Array.Sort(arreglo);      
                lstResultado.Items.Clear();
                lstResultado.Items.Add("Arreglo ordenado:");
                lstResultado.Items.Add(string.Join(", ", arreglo));         
                int dato = int.Parse(txtDato.Text);
                int resultado = BusquedaBi.Buscar(arreglo, dato);           
                if (resultado != -1)
                {
                    lstResultado.Items.Add($"Valor encontrado en el índice: {resultado}");
                }
                else
                {
                    lstResultado.Items.Add("Valor no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
