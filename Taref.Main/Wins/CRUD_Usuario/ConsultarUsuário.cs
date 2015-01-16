using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Taref.Core.Classes;
using Taref.Service.Classes;

namespace Taref.Main.Wins.CRUD_Usuario
{
    public partial class ConsultarUsuário : Form
    {
        #region Constructors

        public ConsultarUsuário()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuario.CurrentRow == null)
            {
                MessageBox.Show("Usuário não selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var resultado = MessageBox.Show(null, "Deseja deletar o usuário selecionado?",
                                            "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                UsuarioService appUsuario = new UsuarioService();

                var usuDeletar = ((Usuario)dataGridViewUsuario.CurrentRow.DataBoundItem);

                if (usuDeletar.Status)
                {
                    MessageBox.Show("Usuários ativos não podem ser deletados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                    return;
                }

                appUsuario.Excluir(usuDeletar.Id);
                CarregarGrid();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string chave = Interaction.InputBox("Digite o login que deseja buscar", "Busca", "...", 250, 250);

            UsuarioService appUsuario = new UsuarioService();
            usuarioBindingSource.DataSource = new List<Usuario>(appUsuario.ListarLoginUsuarios(chave));
            dataGridViewUsuario.DataSource = usuarioBindingSource;
        }

        private void btn_Nome_Click(object sender, EventArgs e)
        {
            string chave = Interaction.InputBox("Digite o nome que deseja buscar", "Busca", "...", 250, 250);

            UsuarioService appUsuario = new UsuarioService();
            usuarioBindingSource.DataSource = new List<Usuario>(appUsuario.ListarNomeUsuarios(chave));
            dataGridViewUsuario.DataSource = usuarioBindingSource;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            UsuarioService appUsuario = new UsuarioService();
            usuarioBindingSource.DataSource = new List<Usuario>(appUsuario.ListarStatusUsuarios(checkBox_Status.Checked));
            dataGridViewUsuario.DataSource = usuarioBindingSource;
        }

        private void CarregarGrid()
        {
            UsuarioService appUsuario = new UsuarioService();
            usuarioBindingSource.DataSource = new List<Usuario>(appUsuario.ListarUsuarios());
            dataGridViewUsuario.DataSource = usuarioBindingSource;
        }

        private void ConsultarUsuário_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        #endregion Methods
    }
}