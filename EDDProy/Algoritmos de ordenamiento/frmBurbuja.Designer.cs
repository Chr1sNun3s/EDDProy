namespace EDDemo.Algoritmos_de_ordenamiento
{
    partial class frmBurbuja
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
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(290, 67);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 0;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(12, 69);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(166, 13);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "Ingrese los datos a ordenar:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(128, 102);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(50, 15);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Orden:";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(184, 69);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 20);
            this.txtDato.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(184, 101);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // frmBurbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 297);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnOrdenar);
            this.Name = "frmBurbuja";
            this.Text = "frmBurbuja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.TextBox txtResultado;
    }
}