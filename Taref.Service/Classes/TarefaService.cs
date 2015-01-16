using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Taref.Core.Classes;
using Taref.Data.DataContexts;

namespace Taref.Service.Classes
{
    public class TarefaService
    {
        #region Constructors

        public TarefaService()
        { Banco = new dbTAREF(); }
        #endregion Constructors

        #region Properties

        private dbTAREF Banco { get; set; }

        #endregion Properties

        #region Methods

        public List<Tarefa> ListarTarefas()
        {
            return Banco.Tarefa.
                Include(x => x.Categoria).
                Include(x => x.Responsavel).
                ToList();
        }

        public List<Tarefa> ListarTarefasPorTitulo(string chave)
        {
            return Banco.Tarefa.
                Include(x => x.Categoria).
                Include(x => x.Responsavel).
                Where(x => x.Titulo.Contains(chave)).
                ToList();
        }

        public List<Tarefa> ListarTarefasPorResponsavel(string chave)
        {
            return Banco.Tarefa.
                Include(x => x.Categoria).
                Include(x => x.Responsavel).
                Where(x => x.Responsavel.Nome.Contains(chave)).
                ToList();
        }

        public List<Tarefa> ListarTarefasPorCategoria(string chave)
        {
            return Banco.Tarefa.
                Include(x => x.Categoria).
                Include(x => x.Responsavel).
                Where(x => x.Categoria.Descrição.Equals(chave)).
                ToList();
        }

        public List<Tarefa> ListarTarefasPorSituacao(int chave)
        {
            return Banco.Tarefa.
                Include(x => x.Categoria).
                Include(x => x.Responsavel).
                Where(x => x.Situação.Equals(chave)).
                ToList();
        }

        public List<Tarefa> ListarTarefasPorTermino(string chave)
        {
            return Banco.Tarefa.
                Include(x => x.Categoria).
                Include(x => x.Responsavel).
                Where(x => x.Termino.ToShortDateString().Equals(chave)).
                ToList();
        }

        public void Salvar(Tarefa tarefa)
        {
            try
            {
                tarefa.Categoria = Banco.Categoria.ToList().FirstOrDefault(x => x.Id == tarefa.Categoria.Id);
                tarefa.Responsavel = Banco.Usuario.ToList().FirstOrDefault(x => x.Id == tarefa.Responsavel.Id);
                Banco.Tarefa.Add(tarefa);
                Banco.SaveChanges();
                MessageBox.Show("Tarefa salva com sucesso");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar Tarefa: " + ex.ToString());
            }
        }

        public void Alterar(Tarefa tarefa)
        {
            try
            {
                var tAlterar = Banco.Tarefa.First(x => x.Id == tarefa.Id);
                tAlterar.Descrição = tarefa.Descrição;
                tAlterar.Prioridade = tarefa.Prioridade;
                tAlterar.Titulo = tarefa.Titulo;
                tAlterar.Situação = tarefa.Situação;
                tAlterar.Inicio = tarefa.Inicio;
                tAlterar.Termino = tarefa.Termino;
                tAlterar.Responsavel = Banco.Usuario.ToList().FirstOrDefault(x => x.Id == tarefa.Responsavel.Id); ;
                tAlterar.Categoria = Banco.Categoria.ToList().FirstOrDefault(x => x.Id == tarefa.Categoria.Id);
                Banco.SaveChanges();
                MessageBox.Show("Tarefa autalizada com sucesso");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar tarefa: " + ex.ToString());
            }
        }

        public void Excluir(int tarefaId)
        {
            try
            {
                var tarExcluir = Banco.Tarefa.First(x => x.Id == tarefaId);
                Banco.Set<Tarefa>().Remove(tarExcluir);
                Banco.SaveChanges();
                MessageBox.Show("Tarefa excluída com sucesso");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar tarefa: " + ex.ToString());
            }
        }

        #endregion Methods
    }
}