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
    public partial class frmPila : Form
    {
        private Pilas pila;

        public frmPila()
        {
            InitializeComponent();
            pila = new Pilas();
        }



        private void MostrarPila()
        {
            lstPila.Items.Clear();
            Nodo actual = pila.ObtenerTop();

            while (actual != null)
            {
                lstPila.Items.Add(actual.Dato);
                actual = actual.sig;
            }
        }

        private void BtnPop_Click(object sender, EventArgs e)
        {
            pila.Pop(lstPila);
            MostrarPila();
            MessageBox.Show("Elemento eliminado de la pila.");
        }

        private void BtnPush_Click(object sender, EventArgs e)
        {
            int dato;
            if (int.TryParse(txtDato.Text, out dato))
            {
                pila.Push(dato, lstPila);
                txtDato.Clear();
                MessageBox.Show("Dato agregado correctamente a la pila.");
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido.");
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Nodo topNodo = pila.ObtenerTop();
            if (topNodo != null)
            {
                MessageBox.Show("Top de la pila: " + topNodo.Dato);
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            int dato;           
            if (int.TryParse(txtDato.Text, out dato))
            {
                Nodo actual = pila.ObtenerTop(); 
                while (actual != null)
                {
                    
                    if (actual.Dato.ToString() == dato.ToString())
                    {
                        encontrado = true;
                        break;
                    }
                    actual = actual.sig;  
                }
                if (encontrado)
                {
                    MessageBox.Show($"Dato {dato} encontrado.");
                }
                else
                {
                    MessageBox.Show($"Dato {dato} no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido.");
            }
        }
    }
}

