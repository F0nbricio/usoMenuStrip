namespace AppExemploMenu
{
    partial class FrmVerde
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormLaranja = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormVerde = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirFormAzul,
            this.exibirFormLaranja,
            this.exibirFormVerde});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // exibirFormAzul
            // 
            this.exibirFormAzul.Name = "exibirFormAzul";
            this.exibirFormAzul.Size = new System.Drawing.Size(180, 22);
            this.exibirFormAzul.Text = "Azul";
            this.exibirFormAzul.Click += new System.EventHandler(this.exibirFormAzul_Click);
            // 
            // exibirFormLaranja
            // 
            this.exibirFormLaranja.Name = "exibirFormLaranja";
            this.exibirFormLaranja.Size = new System.Drawing.Size(180, 22);
            this.exibirFormLaranja.Text = "Laranja";
            this.exibirFormLaranja.Click += new System.EventHandler(this.exibirFormLaranja_Click);
            // 
            // exibirFormVerde
            // 
            this.exibirFormVerde.Name = "exibirFormVerde";
            this.exibirFormVerde.Size = new System.Drawing.Size(180, 22);
            this.exibirFormVerde.Text = "Verde";
            this.exibirFormVerde.Click += new System.EventHandler(this.exibirFormVerde_Click);
            // 
            // FrmVerde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmVerde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirFormAzul;
        private System.Windows.Forms.ToolStripMenuItem exibirFormLaranja;
        private System.Windows.Forms.ToolStripMenuItem exibirFormVerde;
    }
}

