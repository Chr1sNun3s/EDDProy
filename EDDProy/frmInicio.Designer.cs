
namespace EDDemo
{
    partial class frmInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLibealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmosDeOrdenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.burbujaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quicksortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellsortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.externosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intercalacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mezclaDirectaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mezclaNaturalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmosRecursivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmosRecursivosToolStripMenuItem,
            this.estructurasLinealesToolStripMenuItem,
            this.estructurasNoLibealesToolStripMenuItem,
            this.algoritmosDeOrdenamientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilasToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.listasToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras lineales";
            this.estructurasLinealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasLinealesToolStripMenuItem_Click);
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pilasToolStripMenuItem.Text = "Pilas";
            this.pilasToolStripMenuItem.Click += new System.EventHandler(this.pilasToolStripMenuItem_Click);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colasToolStripMenuItem.Text = "Colas";
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // estructurasNoLibealesToolStripMenuItem
            // 
            this.estructurasNoLibealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem});
            this.estructurasNoLibealesToolStripMenuItem.Name = "estructurasNoLibealesToolStripMenuItem";
            this.estructurasNoLibealesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.estructurasNoLibealesToolStripMenuItem.Text = "Estructuras no lineales";
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            this.arbolesToolStripMenuItem.Click += new System.EventHandler(this.arbolesToolStripMenuItem_Click);
            // 
            // algoritmosDeOrdenamientoToolStripMenuItem
            // 
            this.algoritmosDeOrdenamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.internosToolStripMenuItem,
            this.externosToolStripMenuItem});
            this.algoritmosDeOrdenamientoToolStripMenuItem.Name = "algoritmosDeOrdenamientoToolStripMenuItem";
            this.algoritmosDeOrdenamientoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.algoritmosDeOrdenamientoToolStripMenuItem.Text = "Algoritmos de ordenamiento";
            // 
            // internosToolStripMenuItem
            // 
            this.internosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.burbujaToolStripMenuItem,
            this.quicksortToolStripMenuItem,
            this.shellsortToolStripMenuItem,
            this.radixToolStripMenuItem});
            this.internosToolStripMenuItem.Name = "internosToolStripMenuItem";
            this.internosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.internosToolStripMenuItem.Text = "Internos";
            // 
            // burbujaToolStripMenuItem
            // 
            this.burbujaToolStripMenuItem.Name = "burbujaToolStripMenuItem";
            this.burbujaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.burbujaToolStripMenuItem.Text = "Burbuja";
            // 
            // quicksortToolStripMenuItem
            // 
            this.quicksortToolStripMenuItem.Name = "quicksortToolStripMenuItem";
            this.quicksortToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.quicksortToolStripMenuItem.Text = "Quicksort";
            // 
            // shellsortToolStripMenuItem
            // 
            this.shellsortToolStripMenuItem.Name = "shellsortToolStripMenuItem";
            this.shellsortToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.shellsortToolStripMenuItem.Text = "Shellsort";
            // 
            // radixToolStripMenuItem
            // 
            this.radixToolStripMenuItem.Name = "radixToolStripMenuItem";
            this.radixToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.radixToolStripMenuItem.Text = "Radix";
            // 
            // externosToolStripMenuItem
            // 
            this.externosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intercalacionToolStripMenuItem,
            this.mezclaDirectaToolStripMenuItem,
            this.mezclaNaturalToolStripMenuItem});
            this.externosToolStripMenuItem.Name = "externosToolStripMenuItem";
            this.externosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.externosToolStripMenuItem.Text = "Externos";
            // 
            // intercalacionToolStripMenuItem
            // 
            this.intercalacionToolStripMenuItem.Name = "intercalacionToolStripMenuItem";
            this.intercalacionToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.intercalacionToolStripMenuItem.Text = "Intercalacion";
            // 
            // mezclaDirectaToolStripMenuItem
            // 
            this.mezclaDirectaToolStripMenuItem.Name = "mezclaDirectaToolStripMenuItem";
            this.mezclaDirectaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.mezclaDirectaToolStripMenuItem.Text = "Mezcla directa";
            // 
            // mezclaNaturalToolStripMenuItem
            // 
            this.mezclaNaturalToolStripMenuItem.Name = "mezclaNaturalToolStripMenuItem";
            this.mezclaNaturalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.mezclaNaturalToolStripMenuItem.Text = "Mezcla natural";
            // 
            // algoritmosRecursivosToolStripMenuItem
            // 
            this.algoritmosRecursivosToolStripMenuItem.Name = "algoritmosRecursivosToolStripMenuItem";
            this.algoritmosRecursivosToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.algoritmosRecursivosToolStripMenuItem.Text = "Algoritmos Recursivos";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 425);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLibealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmosDeOrdenamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem externosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem burbujaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quicksortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellsortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intercalacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mezclaDirectaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mezclaNaturalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmosRecursivosToolStripMenuItem;
    }
}

