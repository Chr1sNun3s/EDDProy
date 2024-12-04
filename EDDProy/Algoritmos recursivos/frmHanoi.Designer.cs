namespace EDDemo.Algoritmos_recursivos
{
    partial class frmHanoi
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
            this.lblDIscos = new System.Windows.Forms.Label();
            this.txtDiscos = new System.Windows.Forms.TextBox();
            this.btnResolver = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lstMovimientos = new System.Windows.Forms.ListBox();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDIscos
            // 
            this.lblDIscos.AutoSize = true;
            this.lblDIscos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDIscos.Location = new System.Drawing.Point(24, 44);
            this.lblDIscos.Name = "lblDIscos";
            this.lblDIscos.Size = new System.Drawing.Size(127, 15);
            this.lblDIscos.TabIndex = 0;
            this.lblDIscos.Text = "Numero de discos:";
            // 
            // txtDiscos
            // 
            this.txtDiscos.Location = new System.Drawing.Point(157, 44);
            this.txtDiscos.Name = "txtDiscos";
            this.txtDiscos.Size = new System.Drawing.Size(100, 20);
            this.txtDiscos.TabIndex = 1;
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(299, 44);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(75, 23);
            this.btnResolver.TabIndex = 2;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(299, 83);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lstMovimientos
            // 
            this.lstMovimientos.FormattingEnabled = true;
            this.lstMovimientos.Location = new System.Drawing.Point(27, 83);
            this.lstMovimientos.Name = "lstMovimientos";
            this.lstMovimientos.Size = new System.Drawing.Size(230, 173);
            this.lstMovimientos.TabIndex = 4;
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.Location = new System.Drawing.Point(296, 120);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(0, 13);
            this.lblOperaciones.TabIndex = 5;
            // 
            // frmHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 297);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.lstMovimientos);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.txtDiscos);
            this.Controls.Add(this.lblDIscos);
            this.Name = "frmHanoi";
            this.Text = "Hanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDIscos;
        private System.Windows.Forms.TextBox txtDiscos;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lstMovimientos;
        private System.Windows.Forms.Label lblOperaciones;
    }
}