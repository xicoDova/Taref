using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Taref.Core.Classes;
using Taref.Service.Classes;

namespace Taref.Main.Wins.CRUD_Categoria
{
    public partial class ConsultarCategoria : Form
    {
        #region Constructors

        public ConsultarCategoria()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategoria.CurrentRow == null)
            {
                MessageBox.Show("Categoria não selecionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var resultado = MessageBox.Show(null, "Deseja deletar a categoria selecionada?",
                                            "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var catDelete = ((Categoria)dataGridViewCategoria.CurrentRow.DataBoundItem).Id;

                CategoriaService appCategoria = new CategoriaService();
                appCategoria.Excluir(catDelete);
            }

            CarregarGrid();
        }

        private void btn_Desc_Click(object sender, EventArgs e)
        {
            string chave = Interaction.InputBox("Digite a descrição da categoria para busca", "Busca", "...", 150, 150);

            CategoriaService appCategoria = new CategoriaService();
            categoriaBindingSource.DataSource = new List<Categoria>(appCategoria.ListarDescCategorias(chave));
            dataGridViewCategoria.DataSource = categoriaBindingSource;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            CategoriaService appCategoria = new CategoriaService();
            categoriaBindingSource.DataSource = new List<Categoria>(appCategoria.ListarCategorias());
            dataGridViewCategoria.DataSource = categoriaBindingSource;
        }

        private void ConsultarCategoria_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        #endregion Methods
    }
}