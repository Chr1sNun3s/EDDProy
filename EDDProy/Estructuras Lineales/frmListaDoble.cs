using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public partial class frmListaDoble : Form
    {
        private ListaD listaD;
        public frmListaDoble()
        {
            InitializeComponent();
            listaD = new ListaD();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txtDato.Text);
                int posicion = (int)nudPosicion.Value;
                listaD.Push(posicion, dato.ToString());
                MessageBox.Show("Dato insertado correctamente.");
                ActualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int posicion = (int)nudPosicion.Value;
                string eliminado = listaD.Pop(posicion);  
                if (eliminado != null)
                {
                    MessageBox.Show($"Dato eliminado: {eliminado}"); 
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el dato.");
                }
                ActualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

            private void btnMostrar_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            lstLista.Items.Clear();  
            var elementos = listaD.ObtenerDatos();      
            foreach (var item in elementos)
            {
                lstLista.Items.Add(item);
            }
        }
    }
}
