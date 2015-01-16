namespace Taref.Main.Wins.CRUD_Tarefa
{
    partial class CadastroTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroTarefa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Refresh2 = new System.Windows.Forms.Button();
            this.btn_BuscaNome = new System.Windows.Forms.Button();
            this.btn_BuscaLogin = new System.Windows.Forms.Button();
            this.btn_BuscaCate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCategoria = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox_Situacao = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker_Termino = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_Inicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewTarefa = new System.Windows.Forms.DataGridView();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriçãoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Prioridade = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Respon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Cate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1202, 405);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Refresh2);
            this.tabPage1.Controls.Add(this.btn_BuscaNome);
            this.tabPage1.Controls.Add(this.btn_BuscaLogin);
            this.tabPage1.Controls.Add(this.btn_BuscaCate);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dataGridViewUsuario);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewCategoria);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1194, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categorias e Usuários";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Refresh2
            // 
            this.btn_Refresh2.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh2.Image")));
            this.btn_Refresh2.Location = new System.Drawing.Point(1134, 316);
            this.btn_Refresh2.Name = "btn_Refresh2";
            this.btn_Refresh2.Size = new System.Drawing.Size(54, 46);
            this.btn_Refresh2.TabIndex = 22;
            this.btn_Refresh2.UseVisualStyleBackColor = true;
            this.btn_Refresh2.Click += new System.EventHandler(this.btn_Refresh2_Click);
            // 
            // btn_BuscaNome
            // 
            this.btn_BuscaNome.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaNome.Image")));
            this.btn_BuscaNome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BuscaNome.Location = new System.Drawing.Point(720, 316);
            this.btn_BuscaNome.Name = "btn_BuscaNome";
            this.btn_BuscaNome.Size = new System.Drawing.Size(148, 47);
            this.btn_BuscaNome.TabIndex = 9;
            this.btn_BuscaNome.Text = "BUSCA NOME";
            this.btn_BuscaNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuscaNome.UseVisualStyleBackColor = true;
            this.btn_BuscaNome.Click += new System.EventHandler(this.btn_BuscaNome_Click);
            // 
            // btn_BuscaLogin
            // 
            this.btn_BuscaLogin.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaLogin.Image")));
            this.btn_BuscaLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BuscaLogin.Location = new System.Drawing.Point(560, 316);
            this.btn_BuscaLogin.Name = "btn_BuscaLogin";
            this.btn_BuscaLogin.Size = new System.Drawing.Size(154, 47);
            this.btn_BuscaLogin.TabIndex = 8;
            this.btn_BuscaLogin.Text = "BUSCA LOGIN";
            this.btn_BuscaLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuscaLogin.UseVisualStyleBackColor = true;
            this.btn_BuscaLogin.Click += new System.EventHandler(this.btn_BuscaLogin_Click);
            // 
            // btn_BuscaCate
            // 
            this.btn_BuscaCate.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscaCate.Image")));
            this.btn_BuscaCate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BuscaCate.Location = new System.Drawing.Point(99, 316);
            this.btn_BuscaCate.Name = "btn_BuscaCate";
            this.btn_BuscaCate.Size = new System.Drawing.Size(206, 47);
            this.btn_BuscaCate.TabIndex = 7;
            this.btn_BuscaCate.Text = "BUSCA CATEGORIA";
            this.btn_BuscaCate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuscaCate.UseVisualStyleBackColor = true;
            this.btn_BuscaCate.Click += new System.EventHandler(this.btn_BuscaCate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecione um usuário";
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
            this.loginDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dataGridViewUsuario.DataSource = this.usuarioBindingSource;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(429, 39);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.ReadOnly = true;
            this.dataGridViewUsuario.Size = new System.Drawing.Size(759, 270);
            this.dataGridViewUsuario.TabIndex = 5;
            this.dataGridViewUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuario_CellContentClick);
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione uma categoria";
            // 
            // dataGridViewCategoria
            // 
            this.dataGridViewCategoria.AllowUserToAddRows = false;
            this.dataGridViewCategoria.AllowUserToDeleteRows = false;
            this.dataGridViewCategoria.AllowUserToOrderColumns = true;
            this.dataGridViewCategoria.AutoGenerateColumns = false;
            this.dataGridViewCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriçãoDataGridViewTextBoxColumn});
            this.dataGridViewCategoria.DataSource = this.categoriaBindingSource;
            this.dataGridViewCategoria.Location = new System.Drawing.Point(6, 39);
            this.dataGridViewCategoria.Name = "dataGridViewCategoria";
            this.dataGridViewCategoria.ReadOnly = true;
            this.dataGridViewCategoria.Size = new System.Drawing.Size(417, 271);
            this.dataGridViewCategoria.TabIndex = 3;
            this.dataGridViewCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategoria_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.idDataGridViewTextBoxColumn.FillWeight = 30F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriçãoDataGridViewTextBoxColumn
            // 
            this.descriçãoDataGridViewTextBoxColumn.DataPropertyName = "Descrição";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriçãoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.descriçãoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.Name = "descriçãoDataGridViewTextBoxColumn";
            this.descriçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Taref.Core.Classes.Categoria);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox_Situacao);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dateTimePicker_Termino);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dateTimePicker_Inicio);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dataGridViewTarefa);
            this.tabPage2.Controls.Add(this.comboBox_Prioridade);
            this.tabPage2.Controls.Add(this.ID);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_Respon);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_Cate);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_Desc);
            this.tabPage2.Controls.Add(this.txt_Titulo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btn_Refresh);
            this.tabPage2.Controls.Add(this.btn_Search);
            this.tabPage2.Controls.Add(this.btn_Update);
            this.tabPage2.Controls.Add(this.btn_Add);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1194, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarefas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox_Situacao
            // 
            this.comboBox_Situacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Situacao.FormattingEnabled = true;
            this.comboBox_Situacao.Items.AddRange(new object[] {
            "0-Fechada",
            "1-Em andamento",
            "2-Finalizada"});
            this.comboBox_Situacao.Location = new System.Drawing.Point(718, 80);
            this.comboBox_Situacao.Name = "comboBox_Situacao";
            this.comboBox_Situacao.Size = new System.Drawing.Size(190, 26);
            this.comboBox_Situacao.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(634, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 38;
            this.label10.Text = "Situação";
            // 
            // dateTimePicker_Termino
            // 
            this.dateTimePicker_Termino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Termino.Location = new System.Drawing.Point(463, 42);
            this.dateTimePicker_Termino.Name = "dateTimePicker_Termino";
            this.dateTimePicker_Termino.Size = new System.Drawing.Size(132, 27);
            this.dateTimePicker_Termino.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 36;
            this.label9.Text = "Termino";
            // 
            // dateTimePicker_Inicio
            // 
            this.dateTimePicker_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Inicio.Location = new System.Drawing.Point(463, 6);
            this.dateTimePicker_Inicio.Name = "dateTimePicker_Inicio";
            this.dateTimePicker_Inicio.Size = new System.Drawing.Size(132, 27);
            this.dateTimePicker_Inicio.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Início";
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
            this.descriçãoDataGridViewTextBoxColumn1,
            this.responsavelDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.inicioDataGridViewTextBoxColumn,
            this.terminoDataGridViewTextBoxColumn,
            this.prioridadeDataGridViewTextBoxColumn,
            this.situaçãoDataGridViewTextBoxColumn});
            this.dataGridViewTarefa.DataSource = this.tarefaBindingSource;
            this.dataGridViewTarefa.Location = new System.Drawing.Point(9, 112);
            this.dataGridViewTarefa.Name = "dataGridViewTarefa";
            this.dataGridViewTarefa.ReadOnly = true;
            this.dataGridViewTarefa.Size = new System.Drawing.Size(1179, 198);
            this.dataGridViewTarefa.TabIndex = 33;
            this.dataGridViewTarefa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTarefa_CellContentClick);
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Título";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriçãoDataGridViewTextBoxColumn1
            // 
            this.descriçãoDataGridViewTextBoxColumn1.DataPropertyName = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn1.HeaderText = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn1.Name = "descriçãoDataGridViewTextBoxColumn1";
            this.descriçãoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // responsavelDataGridViewTextBoxColumn
            // 
            this.responsavelDataGridViewTextBoxColumn.DataPropertyName = "Responsavel";
            this.responsavelDataGridViewTextBoxColumn.HeaderText = "Responsável";
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
            dataGridViewCellStyle15.Format = "d";
            dataGridViewCellStyle15.NullValue = null;
            this.inicioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.inicioDataGridViewTextBoxColumn.HeaderText = "Início";
            this.inicioDataGridViewTextBoxColumn.Name = "inicioDataGridViewTextBoxColumn";
            this.inicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // terminoDataGridViewTextBoxColumn
            // 
            this.terminoDataGridViewTextBoxColumn.DataPropertyName = "Termino";
            dataGridViewCellStyle16.Format = "d";
            dataGridViewCellStyle16.NullValue = null;
            this.terminoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.terminoDataGridViewTextBoxColumn.HeaderText = "Termino";
            this.terminoDataGridViewTextBoxColumn.Name = "terminoDataGridViewTextBoxColumn";
            this.terminoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prioridadeDataGridViewTextBoxColumn
            // 
            this.prioridadeDataGridViewTextBoxColumn.DataPropertyName = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.HeaderText = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.Name = "prioridadeDataGridViewTextBoxColumn";
            this.prioridadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situaçãoDataGridViewTextBoxColumn
            // 
            this.situaçãoDataGridViewTextBoxColumn.DataPropertyName = "Situação";
            this.situaçãoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situaçãoDataGridViewTextBoxColumn.Name = "situaçãoDataGridViewTextBoxColumn";
            this.situaçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataSource = typeof(Taref.Core.Classes.Tarefa);
            // 
            // comboBox_Prioridade
            // 
            this.comboBox_Prioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Prioridade.FormattingEnabled = true;
            this.comboBox_Prioridade.Items.AddRange(new object[] {
            "0-Nula",
            "1-Muito Baixa",
            "2-Baixa",
            "3-Média",
            "4-Alta",
            "5-Muito Alta"});
            this.comboBox_Prioridade.Location = new System.Drawing.Point(1010, 80);
            this.comboBox_Prioridade.Name = "comboBox_Prioridade";
            this.comboBox_Prioridade.Size = new System.Drawing.Size(178, 26);
            this.comboBox_Prioridade.TabIndex = 32;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(716, 330);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(27, 18);
            this.ID.TabIndex = 31;
            this.ID.Text = "ID";
            this.ID.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(914, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Prioridade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Categoria";
            // 
            // txt_Respon
            // 
            this.txt_Respon.Location = new System.Drawing.Point(718, 42);
            this.txt_Respon.Name = "txt_Respon";
            this.txt_Respon.ReadOnly = true;
            this.txt_Respon.Size = new System.Drawing.Size(470, 27);
            this.txt_Respon.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Responsável";
            // 
            // txt_Cate
            // 
            this.txt_Cate.Location = new System.Drawing.Point(718, 6);
            this.txt_Cate.Name = "txt_Cate";
            this.txt_Cate.ReadOnly = true;
            this.txt_Cate.Size = new System.Drawing.Size(470, 27);
            this.txt_Cate.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Título";
            // 
            // txt_Desc
            // 
            this.txt_Desc.Location = new System.Drawing.Point(98, 42);
            this.txt_Desc.MaxLength = 30;
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(279, 27);
            this.txt_Desc.TabIndex = 24;
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.Location = new System.Drawing.Point(98, 6);
            this.txt_Titulo.MaxLength = 10;
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(279, 27);
            this.txt_Titulo.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Descrição";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.Location = new System.Drawing.Point(1054, 316);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(134, 47);
            this.btn_Refresh.TabIndex = 21;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.Location = new System.Drawing.Point(533, 316);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(177, 47);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "BUSCAR TÍTULO";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Enabled = false;
            this.btn_Update.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.Location = new System.Drawing.Point(288, 316);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(125, 47);
            this.btn_Update.TabIndex = 19;
            this.btn_Update.Text = "ALTERAR";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.Location = new System.Drawing.Point(9, 316);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(144, 47);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = "ADICIONAR";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // CadastroTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 429);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CadastroTarefa";
            this.Text = "Tarefas";
            this.Load += new System.EventHandler(this.CadastroTarefa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Respon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Cate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_BuscaNome;
        private System.Windows.Forms.Button btn_BuscaLogin;
        private System.Windows.Forms.Button btn_BuscaCate;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ComboBox comboBox_Prioridade;
        private System.Windows.Forms.Button btn_Refresh2;
        private System.Windows.Forms.DataGridView dataGridViewTarefa;
        private System.Windows.Forms.ComboBox comboBox_Situacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Termino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Inicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriçãoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situaçãoDataGridViewTextBoxColumn;
    }
}