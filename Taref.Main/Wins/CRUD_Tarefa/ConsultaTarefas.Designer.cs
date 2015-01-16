namespace Taref.Main.Wins.CRUD_Tarefa
{
    partial class ConsultaTarefas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaTarefas));
            this.dataGridViewTarefa = new System.Windows.Forms.DataGridView();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Usu = new System.Windows.Forms.Button();
            this.btn_Cate = new System.Windows.Forms.Button();
            this.btn_Situ = new System.Windows.Forms.Button();
            this.comboBox_Situacao = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Usu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTarefa
            // 
            this.dataGridViewTarefa.AllowUserToAddRows = false;
            this.dataGridViewTarefa.AllowUserToDeleteRows = false;
            this.dataGridViewTarefa.AllowUserToOrderColumns = true;
            this.dataGridViewTarefa.AutoGenerateColumns = false;
            this.dataGridViewTarefa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTarefa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarefa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tituloDataGridViewTextBoxColumn,
            this.descriçãoDataGridViewTextBoxColumn,
            this.responsavelDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.inicioDataGridViewTextBoxColumn,
            this.terminoDataGridViewTextBoxColumn,
            this.situaçãoDataGridViewTextBoxColumn,
            this.prioridadeDataGridViewTextBoxColumn});
            this.dataGridViewTarefa.DataSource = this.tarefaBindingSource;
            this.dataGridViewTarefa.Location = new System.Drawing.Point(12, 102);
            this.dataGridViewTarefa.Name = "dataGridViewTarefa";
            this.dataGridViewTarefa.ReadOnly = true;
            this.dataGridViewTarefa.Size = new System.Drawing.Size(1223, 247);
            this.dataGridViewTarefa.TabIndex = 0;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriçãoDataGridViewTextBoxColumn
            // 
            this.descriçãoDataGridViewTextBoxColumn.DataPropertyName = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.Name = "descriçãoDataGridViewTextBoxColumn";
            this.descriçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responsavelDataGridViewTextBoxColumn
            // 
            this.responsavelDataGridViewTextBoxColumn.DataPropertyName = "Responsavel";
            this.responsavelDataGridViewTextBoxColumn.HeaderText = "Responsavel";
            this.responsavelDataGridViewTextBoxColumn.Name = "responsavelDataGridViewTextBoxColumn";
            this.responsavelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inicioDataGridViewTextBoxColumn
            // 
            this.inicioDataGridViewTextBoxColumn.DataPropertyName = "Inicio";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.inicioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.inicioDataGridViewTextBoxColumn.HeaderText = "Inicio";
            this.inicioDataGridViewTextBoxColumn.Name = "inicioDataGridViewTextBoxColumn";
            this.inicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // terminoDataGridViewTextBoxColumn
            // 
            this.terminoDataGridViewTextBoxColumn.DataPropertyName = "Termino";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.terminoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.terminoDataGridViewTextBoxColumn.HeaderText = "Termino";
            this.terminoDataGridViewTextBoxColumn.Name = "terminoDataGridViewTextBoxColumn";
            this.terminoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situaçãoDataGridViewTextBoxColumn
            // 
            this.situaçãoDataGridViewTextBoxColumn.DataPropertyName = "Situação";
            this.situaçãoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situaçãoDataGridViewTextBoxColumn.Name = "situaçãoDataGridViewTextBoxColumn";
            this.situaçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prioridadeDataGridViewTextBoxColumn
            // 
            this.prioridadeDataGridViewTextBoxColumn.DataPropertyName = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.HeaderText = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.Name = "prioridadeDataGridViewTextBoxColumn";
            this.prioridadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataSource = typeof(Taref.Core.Classes.Tarefa);
            // 
            // btn_Usu
            // 
            this.btn_Usu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Usu.Image")));
            this.btn_Usu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Usu.Location = new System.Drawing.Point(12, 10);
            this.btn_Usu.Name = "btn_Usu";
            this.btn_Usu.Size = new System.Drawing.Size(160, 51);
            this.btn_Usu.TabIndex = 1;
            this.btn_Usu.Text = "RESPONSÁVEL";
            this.btn_Usu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Usu.UseVisualStyleBackColor = true;
            this.btn_Usu.Click += new System.EventHandler(this.btn_Usu_Click);
            // 
            // btn_Cate
            // 
            this.btn_Cate.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cate.Image")));
            this.btn_Cate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cate.Location = new System.Drawing.Point(295, 10);
            this.btn_Cate.Name = "btn_Cate";
            this.btn_Cate.Size = new System.Drawing.Size(142, 51);
            this.btn_Cate.TabIndex = 2;
            this.btn_Cate.Text = "CATEGORIA";
            this.btn_Cate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cate.UseVisualStyleBackColor = true;
            this.btn_Cate.Click += new System.EventHandler(this.btn_Cate_Click);
            // 
            // btn_Situ
            // 
            this.btn_Situ.Image = ((System.Drawing.Image)(resources.GetObject("btn_Situ.Image")));
            this.btn_Situ.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Situ.Location = new System.Drawing.Point(575, 10);
            this.btn_Situ.Name = "btn_Situ";
            this.btn_Situ.Size = new System.Drawing.Size(126, 51);
            this.btn_Situ.TabIndex = 3;
            this.btn_Situ.Text = "SITUAÇÃO";
            this.btn_Situ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Situ.UseVisualStyleBackColor = true;
            this.btn_Situ.Click += new System.EventHandler(this.btn_Situ_Click);
            // 
            // comboBox_Situacao
            // 
            this.comboBox_Situacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Situacao.FormattingEnabled = true;
            this.comboBox_Situacao.Items.AddRange(new object[] {
            "0-Fechada",
            "1-Em andamento",
            "2-Finalizada"});
            this.comboBox_Situacao.Location = new System.Drawing.Point(575, 67);
            this.comboBox_Situacao.Name = "comboBox_Situacao";
            this.comboBox_Situacao.Size = new System.Drawing.Size(182, 26);
            this.comboBox_Situacao.TabIndex = 7;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.Location = new System.Drawing.Point(956, 12);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(124, 47);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "DELETAR";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.Location = new System.Drawing.Point(1173, 12);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(62, 47);
            this.btn_Refresh.TabIndex = 22;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Filtro";
            // 
            // comboBox_Categoria
            // 
            this.comboBox_Categoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriaBindingSource, "Descrição", true));
            this.comboBox_Categoria.DataSource = this.categoriaBindingSource;
            this.comboBox_Categoria.DisplayMember = "Descrição";
            this.comboBox_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Categoria.FormattingEnabled = true;
            this.comboBox_Categoria.Location = new System.Drawing.Point(295, 67);
            this.comboBox_Categoria.Name = "comboBox_Categoria";
            this.comboBox_Categoria.Size = new System.Drawing.Size(198, 26);
            this.comboBox_Categoria.TabIndex = 24;
            this.comboBox_Categoria.ValueMember = "Descrição";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Taref.Core.Classes.Categoria);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Filtro";
            // 
            // comboBox_Usu
            // 
            this.comboBox_Usu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuarioBindingSource, "Nome", true));
            this.comboBox_Usu.DataSource = this.usuarioBindingSource;
            this.comboBox_Usu.DisplayMember = "Id";
            this.comboBox_Usu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Usu.FormattingEnabled = true;
            this.comboBox_Usu.Location = new System.Drawing.Point(12, 67);
            this.comboBox_Usu.Name = "comboBox_Usu";
            this.comboBox_Usu.Size = new System.Drawing.Size(216, 26);
            this.comboBox_Usu.TabIndex = 26;
            this.comboBox_Usu.ValueMember = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Filtro";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Taref.Core.Classes.Usuario);
            // 
            // ConsultaTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Usu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Categoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.comboBox_Situacao);
            this.Controls.Add(this.btn_Situ);
            this.Controls.Add(this.btn_Cate);
            this.Controls.Add(this.btn_Usu);
            this.Controls.Add(this.dataGridViewTarefa);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ConsultaTarefas";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.ConsultaTarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTarefa;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private System.Windows.Forms.Button btn_Usu;
        private System.Windows.Forms.Button btn_Cate;
        private System.Windows.Forms.Button btn_Situ;
        private System.Windows.Forms.ComboBox comboBox_Situacao;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Categoria;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Usu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
    }
}