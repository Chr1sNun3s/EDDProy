namespace EDDemo.Estructuras_Lineales
{
    partial class frmListas
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
            this.BtnListaSimple = new System.Windows.Forms.Button();
            this.BtnListaDoble = new System.Windows.Forms.Button();
            this.BtnListaCircular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnListaSimple
            // 
            this.BtnListaSimple.Location = new System.Drawing.Point(39, 43);
            this.BtnListaSimple.Name = "BtnListaSimple";
            this.BtnListaSimple.Size = new System.Drawing.Size(102, 23);
            this.BtnListaSimple.TabIndex = 0;
            this.BtnListaSimple.Text = "Listas Simples";
            this.BtnListaSimple.UseVisualStyleBackColor = true;
            this.BtnListaSimple.Click += new System.EventHandler(this.BtnListaSimple_Click);
            // 
            // BtnListaDoble
            // 
            this.BtnListaDoble.Location = new System.Drawing.Point(39, 84);
            this.BtnListaDoble.Name = "BtnListaDoble";
            this.BtnListaDoble.Size = new System.Drawing.Size(102, 23);
            this.BtnListaDoble.TabIndex = 1;
            this.BtnListaDoble.Text = "Listas Dobles";
            this.BtnListaDoble.UseVisualStyleBackColor = true;
            this.BtnListaDoble.Click += new System.EventHandler(this.BtnListaDoble_Click);
            // 
            // BtnListaCircular
            // 
            this.BtnListaCircular.Location = new System.Drawing.Point(39, 122);
            this.BtnListaCircular.Name = "BtnListaCircular";
            this.BtnListaCircular.Size = new System.Drawing.Size(102, 23);
            this.BtnListaCircular.TabIndex = 2;
            this.BtnListaCircular.Text = "Listas Circulares";
            this.BtnListaCircular.UseVisualStyleBackColor = true;
            this.BtnListaCircular.Click += new System.EventHandler(this.BtnListaCircular_Click);
            // 
            // frmListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 179);
            this.Controls.Add(this.BtnListaCircular);
            this.Controls.Add(this.BtnListaDoble);
            this.Controls.Add(this.BtnListaSimple);
            this.Name = "frmListas";
            this.Text = "Menu Listas";
            this.Load += new System.EventHandler(this.frmListas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnListaSimple;
        private System.Windows.Forms.Button BtnListaDoble;
        private System.Windows.Forms.Button BtnListaCircular;
    }
}