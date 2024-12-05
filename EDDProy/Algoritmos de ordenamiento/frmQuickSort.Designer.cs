namespace EDDemo.Algoritmos_de_ordenamiento
{
    partial class frmQuickSort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar numeros:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 76);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(76, 15);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(143, 51);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 20);
            this.txtDato.TabIndex = 2;
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(143, 78);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(100, 20);
            this.txtSalida.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(261, 51);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // frmQuickSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 297);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Name = "frmQuickSort";
            this.Text = "frmQuickSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Button btnSort;
    }
}