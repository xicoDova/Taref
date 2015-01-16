using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Taref.Core.Classes;
using Taref.Service.Classes;

namespace Taref.Main.Wins.CRUD_Tarefa
{
    public partial class ConsultaTarefas : Form
    {
        #region Constructors

        public ConsultaTarefas()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void btn_Cate_Click(object sender, EventArgs e)
        {
            bool chave = comboBox_Categoria.SelectedIndex != -1;

            if (chave)
            {
                TarefaService appTarefa = new TarefaService();
                tarefaBindingSource.DataSource = new List<Tarefa>(appTarefa.ListarTarefasPorCategoria(comboBox_Categoria.SelectedItem.ToString()));
                dataGridViewTarefa.DataSource = tarefaBindingSource;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTarefa.CurrentRow == null)
            {
                MessageBox.Show("Tarefa não selecionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var resultado = MessageBox.Show(null, "Deseja deletar as informações da tarefa selecionada?",
                                           "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var tarefaExcluir = ((Tarefa)dataGridViewTarefa.CurrentRow.DataBoundItem).Id;

                TarefaService appTarefa = new TarefaService();
                appTarefa.Excluir(tarefaExcluir);
            }

            CarregarGrid();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btn_Situ_Click(object sender, EventArgs e)
        {
            bool chave = comboBox_Situacao.SelectedIndex != -1;

            if (chave)
            {
                TarefaService appTarefa = new TarefaService();
                tarefaBindingSource.DataSource = new List<Tarefa>(appTarefa.ListarTarefasPorSituacao(comboBox_Situacao.SelectedIndex));
                dataGridViewTarefa.DataSource = tarefaBindingSource;
            }
        }

        private void btn_Usu_Click(object sender, EventArgs e)
        {
            bool chave = comboBox_Usu.SelectedIndex != -1;

            if (chave)
            {
                TarefaService appTarefa = new TarefaService();
                tarefaBindingSource.DataSource = new List<Tarefa>(appTarefa.ListarTarefasPorResponsavel(comboBox_Usu.SelectedItem.ToString()));
                dataGridViewTarefa.DataSource = tarefaBindingSource;
            }
        }

        private void CarregarGrid()
        {
            TarefaService appTarefa = new TarefaService();
            tarefaBindingSource.DataSource = new List<Tarefa>(appTarefa.ListarTarefas());
            dataGridViewTarefa.DataSource = tarefaBindingSource;
            comboBox_Situacao.SelectedIndex = 0;
            CarregaCombos();
        }

        private void CarregaCombos()
        {
            CategoriaService appCategoria = new CategoriaService();
            Categoria categoria = new Categoria();
            comboBox_Categoria.DataSource = new List<Categoria>(appCategoria.ListarCategorias());
            comboBox_Categoria.ValueMember = "Id";
            comboBox_Categoria.DisplayMember = "Descrição";
            comboBox_Categoria.SelectedItem = categoria.Id;
            comboBox_Categoria.Refresh();

            UsuarioService appUsuario = new UsuarioService();
            Usuario usuario = new Usuario();
            comboBox_Usu.DataSource = new List<Usuario>(appUsuario.ListarUsuarios());
            comboBox_Usu.ValueMember = "Id";
            comboBox_Usu.DisplayMember = "Nome";
            comboBox_Usu.SelectedItem = usuario.Id;
            comboBox_Usu.Refresh();

            comboBox_Categoria.SelectedIndex = 0;
            comboBox_Usu.SelectedIndex = 0;
        }

        private void ConsultaTarefas_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        #endregion Methods
    }
}