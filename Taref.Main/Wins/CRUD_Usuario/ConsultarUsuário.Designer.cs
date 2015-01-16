namespace Taref.Main.Wins.CRUD_Usuario
{
    partial class ConsultarUsuário
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarUsuário));
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Nome = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Status = new System.Windows.Forms.Button();
            this.checkBox_Status = new System.Windows.Forms.CheckBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.AllowUserToAddRows = false;
            this.dataGridViewUsuario.AllowUserToDeleteRows = false;
            this.dataGridViewUsuario.AllowUserToOrderColumns = true;
            this.dataGridViewUsuario.AutoGenerateColumns = false;
            this.dataGridViewUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dataGridViewUsuario.DataSource = this.usuarioBindingSource;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(12, 95);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.ReadOnly = true;
            this.dataGridViewUsuario.Size = new System.Drawing.Size(762, 202);
            this.dataGridViewUsuario.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Taref.Core.Classes.Usuario);
            // 
            // btn_Nome
            // 
            this.btn_Nome.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nome.Image")));
            this.btn_Nome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Nome.Location = new System.Drawing.Point(12, 12);
            this.btn_Nome.Name = "btn_Nome";
            this.btn_Nome.Size = new System.Drawing.Size(164, 47);
            this.btn_Nome.TabIndex = 1;
            this.btn_Nome.Text = "BUSCAR NOME";
            this.btn_Nome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nome.UseVisualStyleBackColor = true;
            this.btn_Nome.Click += new System.EventHandler(this.btn_Nome_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login.Image")));
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.Location = new System.Drawing.Point(192, 12);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(168, 47);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "BUSCAR LOGIN";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Status
            // 
            this.btn_Status.Image = ((System.Drawing.Image)(resources.GetObject("btn_Status.Image")));
            this.btn_Status.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Status.Location = new System.Drawing.Point(376, 12);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(179, 47);
            this.btn_Status.TabIndex = 3;
            this.btn_Status.Text = "BUSCAR STATUS";
            this.btn_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Status.UseVisualStyleBackColor = true;
            this.btn_Status.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // checkBox_Status
            // 
            this.checkBox_Status.AutoSize = true;
            this.checkBox_Status.Location = new System.Drawing.Point(376, 65);
            this.checkBox_Status.Name = "checkBox_Status";
            this.checkBox_Status.Size = new System.Drawing.Size(134, 22);
            this.checkBox_Status.TabIndex = 4;
            this.checkBox_Status.Text = "Ativo/Inativo";
            this.checkBox_Status.UseVisualStyleBackColor = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.Location = new System.Drawing.Point(711, 12);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(63, 47);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.Location = new System.Drawing.Point(571, 12);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(124, 47);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "DELETAR";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // ConsultarUsuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 309);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.checkBox_Status);
            this.Controls.Add(this.btn_Status);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Nome);
            this.Controls.Add(this.dataGridViewUsuario);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ConsultarUsuário";
            this.Text = "Consultar Usuários";
            this.Load += new System.EventHandler(this.ConsultarUsuário_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btn_Nome;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.CheckBox checkBox_Status;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Delete;
    }
}