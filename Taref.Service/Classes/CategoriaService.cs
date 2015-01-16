using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Taref.Core.Classes;
using Taref.Data.DataContexts;

namespace Taref.Service.Classes
{
    public class CategoriaService
    {
        #region Constructors

        public CategoriaService()
        { Banco = new dbTAREF(); }

        #endregion Constructors

        #region Properties

        private dbTAREF Banco { get; set; }

        #endregion Properties

        #region Methods

        public void Alterar(Categoria categoria)
        {
            try
            {
                var catAlterar = Banco.Categoria.First(x => x.Id == categoria.Id);

                bool chave = catAlterar.ListaTarefas.Count > 0;
                if (chave) { MessageBox.Show("Você não pode atualizar as informações de categorias com tarefa atribuída"); return; }

                catAlterar.Descrição = categoria.Descrição;
                Banco.SaveChanges();
                MessageBox.Show("Categoria alterada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a categoria: " + ex.ToString());
            }
        }

        public void Excluir(int categoriaId)
        {
            try
            {
                var catAlterar = Banco.Categoria.First(x => x.Id == categoriaId);

                bool chave = catAlterar.ListaTarefas.Count > 0;
                if (chave) { MessageBox.Show("Você não pode deletar uma categoria que esteja com tarefas atribuídas"); return; }

                Banco.Set<Categoria>().Remove(catAlterar);
                Banco.SaveChanges();
                MessageBox.Show("Categoria deletada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar a categoria: " + ex.ToString());
            }
        }

        public List<Categoria> ListarCategorias()
        {
            return Banco.Categoria.ToList();
        }

        public List<Categoria> ListarDescCategorias(string chave)
        {
            return Banco.Categoria.Where(x => x.Descrição.Contains(chave)).ToList();
        }

        public void Salvar(Categoria categoria)
        {
            try
            {
                Banco.Categoria.Add(categoria);
                Banco.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar categoria: " + ex.ToString());
            }
        }

        #endregion Methods
    }
}