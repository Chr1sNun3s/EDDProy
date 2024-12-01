
namespace EDDemo.Estructuras_Lineales
{
    partial class frmPila
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
            this.BtnPop = new System.Windows.Forms.Button();
            this.BtnPush = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnPop
            // 
            this.BtnPop.Location = new System.Drawing.Point(270, 80);
            this.BtnPop.Name = "BtnPop";
            this.BtnPop.Size = new System.Drawing.Size(75, 23);
            this.BtnPop.TabIndex = 0;
            this.BtnPop.Text = "Pop";
            this.BtnPop.UseVisualStyleBackColor = true;
            this.BtnPop.Click += new System.EventHandler(this.BtnPop_Click);
            // 
            // BtnPush
            // 
            this.BtnPush.Location = new System.Drawing.Point(270, 41);
            this.BtnPush.Name = "BtnPush";
            this.BtnPush.Size = new System.Drawing.Size(75, 23);
            this.BtnPush.TabIndex = 1;
            this.BtnPush.Text = "Push";
            this.BtnPush.UseVisualStyleBackColor = true;
            this.BtnPush.Click += new System.EventHandler(this.BtnPush_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(270, 125);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 2;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dato:";
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(16, 80);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(224, 95);
            this.lstPila.TabIndex = 5;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(54, 41);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 20);
            this.txtDato.TabIndex = 6;
            // 
            // frmPila
            // 
            this.ClientSize = new System.Drawing.Size(438, 282);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.lstPila);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnPush);
            this.Controls.Add(this.BtnPop);
            this.Name = "frmPila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button BtnPop;
        private System.Windows.Forms.Button BtnPush;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.TextBox txtDato;
    }
    }