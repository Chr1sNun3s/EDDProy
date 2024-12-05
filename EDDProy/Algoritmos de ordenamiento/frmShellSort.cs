﻿using System;
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
    public partial class frmShellSort : Form
    {
        public frmShellSort()
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
                ShellSort.Sort(array);        
                txtOutput.Text = string.Join(", ",array);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}