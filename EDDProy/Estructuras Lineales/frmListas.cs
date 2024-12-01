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
    public partial class frmListas : Form
    {
        public frmListas()
        {
            InitializeComponent();
        }

        private void frmListas_Load(object sender, EventArgs e)
        {

        }

        private void BtnListaSimple_Click(object sender, EventArgs e)
        {
            frmListaSimple mListaS = new frmListaSimple();
            mListaS.IsMdiContainer = true;
            mListaS.Show();
        }

        private void BtnListaDoble_Click(object sender, EventArgs e)
        {
            frmListaDoble mListaD = new frmListaDoble();
            mListaD.IsMdiContainer = true;
            mListaD.Show();
        }

        private void BtnListaCircular_Click(object sender, EventArgs e)
        {
            frmListaCircular mListaC = new frmListaCircular();
            mListaC.IsMdiContainer = true;
            mListaC.Show();
        }
    }
}
