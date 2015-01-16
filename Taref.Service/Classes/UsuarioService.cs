using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Taref.Core.Classes;
using Taref.Data.DataContexts;

namespace Taref.Service.Classes
{
    public class UsuarioService
    {
        #region Constructors

        public UsuarioService()
        { Banco = new dbTAREF(); }

        #endregion Constructors

        #region Properties

        private dbTAREF Banco { get; set; }

        #endregion Properties

        #region Methods

        public List<Usuario> ListarUsuarios()
        {
            return Banco.Usuario.ToList();
        }

        public List<Usuario> ListarNomeUsuarios(string chave)
        {
            return Banco.Usuario.Where(x => x.Nome.Contains(chave)).ToList();
        }

        public List<Usuario> ListarLoginUsuarios(string chave)
        {
            return Banco.Usuario.Where(x => x.Login.Equals(chave)).ToList();
        }

        public List<Usuario> ListarStatusUsuarios(bool chave)
        {
            return Banco.Usuario.Where(x => x.Status.Equals(chave)).ToList();
        }

        public void Salvar(Usuario usuario)
        {
            try
            {
                Banco.Usuario.Add(usuario);
                Banco.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar usuário: " + ex.ToString());
            }
        }

        public void Alterar(Usuario usuario)
        {
            try
            {
                var usuAlterar = Banco.Usuario.First(x => x.Id == usuario.Id);

                bool chave = usuAlterar.ListaTarefas.Count > 0;
                if (chave) { MessageBox.Show("Você não pode atualizar as informações de usuários com tarefa atribuída"); return; }

                usuAlterar.Login = usuario.Login;
                usuAlterar.Nome = usuario.Nome;
                usuAlterar.Senha = usuario.Senha;
                usuAlterar.Status = usuario.Status;

                Banco.SaveChanges();
                MessageBox.Show("Usuário alterado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar dados do usuário: " + ex.ToString());
            }
        }

        public void Excluir(int usuarioId)
        {
            try
            {
                var usuAlterar = Banco.Usuario.First(x => x.Id == usuarioId);
                Banco.Set<Usuario>().Remove(usuAlterar);
                Banco.SaveChanges();
                MessageBox.Show("Usuário excluido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir dados do usuário: " + ex.ToString());
            }
        }

        #endregion Methods
    }
}