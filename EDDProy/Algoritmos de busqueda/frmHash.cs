using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Algoritmos_de_busqueda.Clases;

namespace EDDemo.Algoritmos_de_busqueda
{
    public partial class frmHash : Form
    {
        private Hash _hashTable;
        public frmHash()
        {
            InitializeComponent();
            _hashTable = new Hash(10);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                int clave = int.Parse(txtClave.Text);
                string valor = txtValor.Text;            
                _hashTable.Ingresar(clave, valor);
                MessageBox.Show("Elemento insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);           
                txtClave.Clear();
                txtValor.Clear();
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
                int clave = int.Parse(txtBuscarClave.Text);          
                string resultado = _hashTable.Buscar(clave);
                lstResultado.Items.Clear();
                lstResultado.Items.Add($"Clave: {clave}, Valor: {resultado}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string[] lines = File.ReadAllLines(openFileDialog.FileName);

                        _hashTable.Clear();

                        foreach (var line in lines)
                        {
                            string[] parts = line.Split(',');

                            if (parts.Length == 2 && int.TryParse(parts[0], out int key))
                            {
                                _hashTable.Ingresar(key, parts[1]);
                            }
                            else
                            {
                                MessageBox.Show($"Línea inválida: {line}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        MessageBox.Show("Archivo cargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
