using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Taref.Core.Classes;
using Taref.Service.Classes;

namespace Taref.Main.Wins.CRUD_Categoria
{
    public partial class CadastroCategoria : Form
    {
        #region Constructors

        public CadastroCategoria()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (VerificaCampoVazio())
            {
                MessageBox.Show("Campos não podem ser vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CategoriaService appCategoria = new CategoriaService();

            Categoria categoria = new Categoria();
            categoria.Descrição = txt_Desc.Text;

            appCategoria.Salvar(categoria);

            CarregarGrid();
            OrganizaCampos();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            OrganizaCampos();
            CarregarGrid();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string chave = Interaction.InputBox("Digite a descrição da categoria", "Busca", "...", 250, 250);

            CategoriaService appCategoria = new CategoriaService();
            categoriaBindingSource.DataSource = new List<Categoria>(appCategoria.ListarDescCategorias(chave));
            dataGridViewCategoria.DataSource = categoriaBindingSource;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(null, "Deseja alterar as informações da categoria selecionada?",
                "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (VerificaCampoVazio())
                {
                    MessageBox.Show("Campo com informação vazia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                CategoriaService appCategoria = new CategoriaService();

                var catAlterar = new Categoria();
                catAlterar.Id = Convert.ToInt32(ID.Text);
                catAlterar.Descrição = txt_Desc.Text;

                appCategoria.Alterar(catAlterar);
            }

            OrganizaCampos();
            CarregarGrid();
        }

        private void CadastroCategoria_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            OrganizaCampos();
        }

        private void CarregarGrid()
        {
            CategoriaService appCategoria = new CategoriaService();
            categoriaBindingSource.DataSource = new List<Categoria>(appCategoria.ListarCategorias());
            dataGridViewCategoria.DataSource = categoriaBindingSource;
        }

        private void dataGridViewCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCategoria.CurrentRow == null)
            {
                MessageBox.Show("Categoria não selecionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CategoriaService appCategoria = new CategoriaService();

            var catAlterar = ((Categoria)dataGridViewCategoria.CurrentRow.DataBoundItem);
            ID.Text = catAlterar.Id.ToString();
            txt_Desc.Text = catAlterar.Descrição;
            btn_Update.Enabled = true;
        }

        private void OrganizaCampos()
        {
            txt_Desc.Text = string.Empty;
            txt_Desc.Focus();
            btn_Update.Enabled = false;
        }

        private bool VerificaCampoVazio()
        {
            bool chave = txt_Desc.Text == string.Empty;
            return chave;
        }

        #endregion Methods
    }
}