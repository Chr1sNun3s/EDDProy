using EDDemo.Estructuras_No_Lineales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Estructuras_Lineales
{   
    public partial class frmColas : Form
    {   
        private Colas cola;
        public frmColas()
        {
            InitializeComponent();
            cola = new Colas();
        }

        private void frmColas_Load(object sender, EventArgs e)
        {

        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(txtValor.Text);
                NodoBinario nodo = new NodoBinario(valor);
                cola.Enqueue(nodo);
                MostrarCola();
                txtValor.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            try
            {
                NodoBinario nodo = cola.Dequeue();

                if (nodo != null)
                {
                    MessageBox.Show($"Elemento desencolado: {nodo.Dato}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MostrarCola();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(txtValor.Text);

                if (cola.Buscar(valor))
                {
                    MessageBox.Show($"El valor {valor} se encuentra en la cola.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"El valor {valor} no se encuentra en la cola.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtValor.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarCola()
        {
            lstCola.Items.Clear();
            NodoBinario actual = cola.primero;
            while (actual != null)
            {
                lstCola.Items.Add(actual.Dato);
                actual = actual.Der;
            }
        }
    }
}
