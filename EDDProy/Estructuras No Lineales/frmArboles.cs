using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//sing GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text),
                                ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";

 
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString =  b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);

            
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }


        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null) {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = ""; 
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
             
            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos =1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();          
            int datoBuscado = int.Parse(txtDato.Text);
            bool encontrado = miArbol.BuscarNodo(datoBuscado, miRaiz);        
            if (encontrado)
            {
                MessageBox.Show("El dato fue encontrado en el arbol.");
            }
            else
            {
                MessageBox.Show("El dato no fue encontrado en el arbol.");
            }

            txtDato.Text = "";
        }

        private void txtArbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPodar_Click(object sender, EventArgs e)
        {
            if (miArbol.EstaVacio())
            {
                MessageBox.Show("Arbol vacio");
            }
            else
            {
                miArbol.PodarArbolCompleto();
                MessageBox.Show("El arbol ha sido podado por completo");
                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miArbol.RegresaRaiz());
                txtArbol.Text = miArbol.strArbol;
            }
        }

        private void btnPredecesor_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtDato.Text, out valor))
            {
                bool eliminado = miArbol.EliminarPredecesor(valor);

                if (eliminado)
                {
                    MessageBox.Show($"El nodo con valor {valor} ha sido eliminado");
                    miArbol.strArbol = "";
                    miArbol.MuestraArbolAcostado(1, miArbol.RegresaRaiz());
                    txtArbol.Text = miArbol.strArbol;
                }
                else
                {
                    MessageBox.Show($"El nodo con valor {valor} no se encuentra en el arbol");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor que sea valido");
            }
        }

        private void btnSucesor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                bool eliminado = miArbol.EliminarSucesor(valor);
                if (eliminado) 
                {
                    MessageBox.Show($"El {valor} ha sido eliminado");
                    miArbol.strArbol = "";
                    miArbol.MuestraArbolAcostado(1, miArbol.RegresaRaiz());
                    txtArbol.Text = miArbol.strArbol;
                }
                else
                    MessageBox.Show($"El {valor} no se encuentra en el arbol");
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor que sea valido.");
            }
        }

        private void btnAmplitud_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz(); 
            {
                MessageBox.Show("El arbol esta vacio.");
                return;
            }
            miArbol.Amplitud(miRaiz);
            MessageBox.Show("Recorrido por niveles: " + miArbol.strRecorrido);

        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio.");
                return;
            }
            int altura = miArbol.CalcularAltura(miRaiz);
            MessageBox.Show("La altura del arbol es: " + altura);
        }

        private void btnContarHojas_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio.");
                return;
            }

            int numeroDeHojas = miArbol.ContarHojas(miRaiz);
            MessageBox.Show("El numero total de hojas en el arbol es: " + numeroDeHojas);
        }

        private void btnContarNodos_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio.");
                return;
            }

            int numeroDeNodos = miArbol.ContarNodos(miRaiz);
            MessageBox.Show("El numero total de nodos en el arbol es: " + numeroDeNodos);
        }

        private void btnCompleto_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            if (miArbol.EsCompleto(miRaiz))
            {
                MessageBox.Show("El arbol es completo.");
            }
            else
            {
                MessageBox.Show("El arbol no es completo.");
            }
        }

        private void btnLleno_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            if (miArbol.esLleno(miRaiz))
                MessageBox.Show("El arbol está lleno.");
            else
                MessageBox.Show("El arbol no está lleno.");
        }
    }
}
