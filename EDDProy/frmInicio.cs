using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Algoritmos_recursivos;
using EDDemo.Algoritmos_de_ordenamiento;
using EDDemo.Algoritmos_de_ordenamiento.Clases;
using EDDemo.Algoritmos_de_busqueda;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila mPilas = new frmPila();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColas mColas = new frmColas();
            mColas.MdiParent = this;
            mColas.Show();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListas mListas = new frmListas();
            mListas.MdiParent = this;
            mListas.Show();
        }

        private void factorialDeUnNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactorial mFactorial = new frmFactorial();
            mFactorial.MdiParent = this;
            mFactorial.Show();
        }

        private void calculoDeUnExponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExponente mExponente = new frmExponente();
            mExponente.MdiParent = this;
            mExponente.Show();
        }

        private void sumarLosElementosDeUnArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSumaArreglo mArreglo = new frmSumaArreglo();
            mArreglo.MdiParent = this;
            mArreglo.Show();
        }

        private void secuenciaDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFibonacci mFibonacci = new frmFibonacci();
            mFibonacci.MdiParent = this;
            mFibonacci.Show();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaBinaria mBusqueda = new frmBusquedaBinaria();
            mBusqueda.MdiParent = this;
            mBusqueda.Show();
        }

        private void torreDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHanoi mHanoi = new frmHanoi();
            mHanoi.MdiParent = this;
            mHanoi.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja mBurbuja = new frmBurbuja();
            mBurbuja.MdiParent = this;
            mBurbuja.Show();
        }

        private void quicksortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuickSort mQuickSort = new frmQuickSort();
            mQuickSort.MdiParent = this;
            mQuickSort.Show();
        }

        private void shellsortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShellSort mShellSort = new frmShellSort();  
            mShellSort.MdiParent = this;
            mShellSort.Show();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadixSort mRadixSort = new frmRadixSort();
            mRadixSort.MdiParent = this;
            mRadixSort.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void busquedaHashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHash mHash = new frmHash();
            mHash.MdiParent = this;
            mHash.Show();
        }

        private void busquedaBinariaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBusquedaBi mBusquedaBi = new frmBusquedaBi();
            mBusquedaBi.MdiParent = this;
            mBusquedaBi.Show();
        }
    }
}
