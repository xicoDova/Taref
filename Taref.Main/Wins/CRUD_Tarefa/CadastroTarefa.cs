using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Taref.Core.Classes;
using Taref.Service.Classes;

namespace Taref.Main.Wins.CRUD_Tarefa
{
    public partial class CadastroTarefa : Form
    {
        #region Constructors

        public CadastroTarefa()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void btn_BuscaCate_Click(object sender, EventArgs e)
        {
            string chave = Interaction.InputBox("Digite a descrição da categoria para busca", "Busca", "...", 150, 150);

            CategoriaService appCategoria = new CategoriaService();
            categoriaBindingSource.DataSource = new List<Categoria>(appCategoria.ListarDescCategorias(chave));
            dataGridViewCategoria.DataSource = categoriaBindingSource;
        }

        private void btn_BuscaLogin_Click(object sender, EventArgs e)
        {
            string chave = Interaction.InputBox("Digite o login que deseja buscar", "Busca", "...", 250, 250);

            UsuarioService appUsuario = new UsuarioService();
            usuarioBindingSource.DataSource = new List<Usuario>(appUsuario.ListarLoginUsuarios(chave));
            dataGridViewUsuario.DataSource = usuarioBindingSource;
        }

        private void btn_BuscaNome_Click(object sender, EventArgs e)
        {
            string chave = Interaction.InputBox("Digite o nome que deseja buscar", "Busca", "...", 250, 250);

            UsuarioService appUsuario = new UsuarioService();
            usuarioBindingSource.DataSource = new List<Usuario>(appUsuario.ListarNomeUsuarios(chave));
            dataGridViewUsuario.DataSource = usuarioBindingSource;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            CarregarGrids();
            OrganizaCampos();
        }

        private void btn_Refresh2_Click(object sender, EventArgs e)
        {
            CarregarGrids();
            OrganizaCampos();
        }

        private void CadastroTarefa_Load(object sender, EventArgs e)
        {
            CarregarGrids();
            OrganizaCampos();
        }

        private void CarregarGrids()
        {
            CategoriaService appCategoria = new CategoriaService();
            categoriaBindingSource.DataSource = new List<Categoria>(appCategoria.ListarCategorias());
            dataGridViewCategoria.DataSource = categoriaBindingSource;

            UsuarioService appUsuario = new UsuarioService();
            usuarioBindingSource.DataSource = new List<Usuario>(appUsuario.ListarStatusUsuarios(true));
            dataGridViewUsuario.DataSource = usuarioBindingSource;

            TarefaService appTarefa = new TarefaService();
            tarefaBindingSource.DataSource = new List<Tarefa>(appTarefa.ListarTarefas());
            dataGridViewTarefa.DataSource = tarefaBindingSource;
        }

        private void OrganizaCampos()
        {
            txt_Titulo.Text = string.Empty;
            txt_Desc.Text = string.Empty;
            txt_Cate.Text = string.Empty;
            txt_Respon.Text = string.Empty;
            comboBox_Prioridade.SelectedIndex = 0;
            comboBox_Situacao.SelectedIndex = 0;
            txt_Titulo.Focus();
            btn_Update.Enabled = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                MessageBox.Show("Campos não podem ficar sem informação", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TarefaService appTarefa = new TarefaService();

            Tarefa tarefa = new Tarefa();
            tarefa.Titulo = txt_Titulo.Text;
            tarefa.Descrição = txt_Desc.Text;
            tarefa.Prioridade = comboBox_Prioridade.SelectedIndex;
            tarefa.Situação = comboBox_Situacao.SelectedIndex;
            tarefa.Inicio = dateTimePicker_Inicio.Value;
            tarefa.Termino = dateTimePicker_Termino.Value;

            if (dataGridViewCategoria.CurrentRow == null || dataGridViewUsuario.CurrentRow == null)
            {
                MessageBox.Show("Categoria ou Usuário não selecionado(s)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var usua = ((Usuario)dataGridViewUsuario.CurrentRow.DataBoundItem);
            var categ = ((Categoria)dataGridViewCategoria.CurrentRow.DataBoundItem);

            tarefa.Responsavel = usua;
            tarefa.Categoria = categ;

            appTarefa.Salvar(tarefa);

            try
            {
                usua.AddTarefas(tarefa);
                categ.AddTarefas(tarefa);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar tarefa na lista de tarefas de usuário e/ou categoria: " + ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            OrganizaCampos();
            CarregarGrids();
        }

        private void dataGridViewCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCategoria.CurrentRow == null)
            {
                MessageBox.Show("Categoria não selecionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var categ = ((Categoria)dataGridViewCategoria.CurrentRow.DataBoundItem);
            txt_Cate.Text = categ.Descrição;
        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsuario.CurrentRow == null)
            {
                MessageBox.Show("Usuário não selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var usua = ((Usuario)dataGridViewUsuario.CurrentRow.DataBoundItem);
            txt_Respon.Text = usua.Login;
        }

        private bool VerificarCamposVazios()
        {
            bool chave = txt_Cate.Text == string.Empty || txt_Respon.Text == string.Empty ||
                         txt_Titulo.Text == string.Empty || txt_Desc.Text == string.Empty ||
                         comboBox_Prioridade.SelectedIndex == -1;
            return chave;
        }

        #endregion Methods

        private void dataGridViewTarefa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTarefa.CurrentRow == null)
            {
                MessageBox.Show("Tarefa não selecionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var tarefa = ((Tarefa)dataGridViewTarefa.CurrentRow.DataBoundItem);
            ID.Text = tarefa.Id.ToString();
            txt_Titulo.Text = tarefa.Titulo;
            txt_Desc.Text = tarefa.Descrição;
            txt_Cate.Text = tarefa.Categoria.Descrição;
            txt_Respon.Text = tarefa.Responsavel.Login;
            dateTimePicker_Inicio.Value = tarefa.Inicio;
            dateTimePicker_Termino.Value = tarefa.Termino;
            comboBox_Situacao.SelectedIndex = tarefa.Situação;
            comboBox_Prioridade.SelectedIndex = tarefa.Prioridade;
            btn_Update.Enabled = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(null, "Deseja alterar as informações da tarefa selecionada?",
                                            "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (VerificarCamposVazios())
                {
                    MessageBox.Show("Campos não podem ficar sem informação", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                TarefaService appTarefa = new TarefaService();

                var tarAlterar = new Tarefa();
                tarAlterar.Id = Convert.ToInt32(ID.Text);
                tarAlterar.Titulo = txt_Titulo.Text;
                tarAlterar.Descrição = txt_Desc.Text;
                tarAlterar.Prioridade = comboBox_Prioridade.SelectedIndex;
                tarAlterar.Situação = comboBox_Situacao.SelectedIndex;
                tarAlterar.Inicio = dateTimePicker_Inicio.Value;
                tarAlterar.Termino = dateTimePicker_Termino.Value;

                if (dataGridViewCategoria.CurrentRow == null || dataGridViewUsuario.CurrentRow == null)
                {
                    MessageBox.Show("Categoria ou Usuário não selecionado(s)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var usua = ((Usuario)dataGridViewUsuario.CurrentRow.DataBoundItem);
                var categ = ((Categoria)dataGridViewCategoria.CurrentRow.DataBoundItem);

                tarAlterar.Responsavel = usua;
                tarAlterar.Categoria = categ;

                appTarefa.Alterar(tarAlterar);

                try
                {
                    usua.ListaTarefas.Add(tarAlterar);
                    categ.ListaTarefas.Add(tarAlterar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar tarefa na lista de tarefas de usuário e/ou categoria: " + ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                OrganizaCampos();
                CarregarGrids();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string chave = Interaction.InputBox("Digite o titulo da tarefa que deseja buscar", "Busca", "...", 250, 250);

            TarefaService appTarefa = new TarefaService();
            tarefaBindingSource.DataSource = new List<Tarefa>(appTarefa.ListarTarefasPorTitulo(chave));
            dataGridViewTarefa.DataSource = tarefaBindingSource;
        }
    }
}