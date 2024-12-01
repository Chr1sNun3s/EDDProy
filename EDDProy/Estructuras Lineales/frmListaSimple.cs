using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDDemo.Estructuras_Lineales;
using System.Windows.Forms;


namespace EDDemo.Estructuras_Lineales
{
    public partial class frmListaSimple : Form
    {
        private ListaS listaS;
        public frmListaSimple()
        {
            InitializeComponent();
            listaS = new ListaS();
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                listaS.Push("dato "+1);
                MessageBox.Show($"Dato {dato} insertado.");
                txtDato.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un numero valido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            listaS.Pop();
            MessageBox.Show("Primer dato eliminado.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                listaS.Buscar("dato");
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un numero valido.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();
            var datos = listaS.ObtenerDatos(); 
            foreach (var d in datos)
            {
                lstDatos.Items.Add(d);
            }
        }
    }
}
