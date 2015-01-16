namespace Taref.Main.Wins
{
    partial class PrincipalWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalWin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarTarefaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTarefaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acompanharTarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Logado = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarefasToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.gerenciaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tarefasToolStripMenuItem
            // 
            this.tarefasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarTarefaToolStripMenuItem,
            this.consultarTarefaToolStripMenuItem});
            this.tarefasToolStripMenuItem.Name = "tarefasToolStripMenuItem";
            this.tarefasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tarefasToolStripMenuItem.Text = "Tarefas";
            // 
            // adicionarTarefaToolStripMenuItem
            // 
            this.adicionarTarefaToolStripMenuItem.Name = "adicionarTarefaToolStripMenuItem";
            this.adicionarTarefaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.adicionarTarefaToolStripMenuItem.Text = "Adicionar tarefa";
            this.adicionarTarefaToolStripMenuItem.Click += new System.EventHandler(this.adicionarTarefaToolStripMenuItem_Click);
            // 
            // consultarTarefaToolStripMenuItem
            // 
            this.consultarTarefaToolStripMenuItem.Name = "consultarTarefaToolStripMenuItem";
            this.consultarTarefaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.consultarTarefaToolStripMenuItem.Text = "Consultar tarefa";
            this.consultarTarefaToolStripMenuItem.Click += new System.EventHandler(this.consultarTarefaToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarUsuárioToolStripMenuItem,
            this.consultarUsuárioToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // adicionarUsuárioToolStripMenuItem
            // 
            this.adicionarUsuárioToolStripMenuItem.Name = "adicionarUsuárioToolStripMenuItem";
            this.adicionarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.adicionarUsuárioToolStripMenuItem.Text = "Adicionar usuário";
            this.adicionarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.adicionarUsuárioToolStripMenuItem_Click);
            // 
            // consultarUsuárioToolStripMenuItem
            // 
            this.consultarUsuárioToolStripMenuItem.Name = "consultarUsuárioToolStripMenuItem";
            this.consultarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.consultarUsuárioToolStripMenuItem.Text = "Consultar usuário";
            this.consultarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.consultarUsuárioToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarCategoriaToolStripMenuItem,
            this.consultarCategoriaToolStripMenuItem});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // adicionarCategoriaToolStripMenuItem
            // 
            this.adicionarCategoriaToolStripMenuItem.Name = "adicionarCategoriaToolStripMenuItem";
            this.adicionarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.adicionarCategoriaToolStripMenuItem.Text = "Adicionar categoria";
            this.adicionarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.adicionarCategoriaToolStripMenuItem_Click);
            // 
            // consultarCategoriaToolStripMenuItem
            // 
            this.consultarCategoriaToolStripMenuItem.Name = "consultarCategoriaToolStripMenuItem";
            this.consultarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.consultarCategoriaToolStripMenuItem.Text = "Consultar categoria";
            this.consultarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.consultarCategoriaToolStripMenuItem_Click);
            // 
            // gerenciaToolStripMenuItem
            // 
            this.gerenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acompanharTarefasToolStripMenuItem});
            this.gerenciaToolStripMenuItem.Name = "gerenciaToolStripMenuItem";
            this.gerenciaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.gerenciaToolStripMenuItem.Text = "Gerencia";
            // 
            // acompanharTarefasToolStripMenuItem
            // 
            this.acompanharTarefasToolStripMenuItem.Name = "acompanharTarefasToolStripMenuItem";
            this.acompanharTarefasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.acompanharTarefasToolStripMenuItem.Text = "Acompanhar tarefas";
            this.acompanharTarefasToolStripMenuItem.Click += new System.EventHandler(this.acompanharTarefasToolStripMenuItem_Click);
            // 
            // Logado
            // 
            this.Logado.AutoSize = true;
            this.Logado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Logado.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logado.ForeColor = System.Drawing.Color.Maroon;
            this.Logado.Location = new System.Drawing.Point(12, 626);
            this.Logado.Name = "Logado";
            this.Logado.Size = new System.Drawing.Size(63, 29);
            this.Logado.TabIndex = 4;
            this.Logado.Text = "AUX";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Data.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(12, 661);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(78, 29);
            this.Data.TabIndex = 6;
            this.Data.Text = "DATE";
            // 
            // PrincipalWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 382);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Logado);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PrincipalWin";
            this.Text = "Taref - Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalWin_FormClosing);
            this.Load += new System.EventHandler(this.PrincipalWin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tarefasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarTarefaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTarefaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acompanharTarefasToolStripMenuItem;
        private System.Windows.Forms.Label Logado;
        private System.Windows.Forms.Label Data;
    }
}