using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Taref.Core.Classes;
using Taref.Service.Classes;

namespace Taref.Main.Wins.CRUD_Usuario
{
    public partial class CadastroUsuario : Form
    {
        #region Constructors

        public CadastroUsuario()
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

            UsuarioService appUsuario = new UsuarioService();

            Usuario usuario = new Usuario();
            usuario.Login = txt_Login.Text;
            usuario.Senha = txt_Senha.Text;
            usuario.Nome = txt_Nome.Text;
            usuario.Status = checkBox_Status.Checked;

            appUsuario.Salvar(usuario);

            OrganizaCampos();
            CarregarGrid();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            OrganizaCampos();
            CarregarGrid();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string chave = Interaction.InputBox("Digite o nome que deseja buscar", "Busca", "...", 250, 250);

            UsuarioService appUsuario = new UsuarioService();
            usuarioBindingSource.DataSource = new List<Usuario>(appUsuario.ListarNomeUsuarios(chave));
            dataGridViewUsuario.DataSource = usuarioBindingSource;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(null, "Deseja alterar as informações do cliente selecionado?",
                                            "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (VerificaCampoVazio())
                {
                    MessageBox.Show("Usuário não selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                UsuarioService appUsuario = new UsuarioService();

                var usuAlterar = new Usuario();

                usuAlterar.Id = Convert.ToInt32(ID.Text);
                usuAlterar.Login = txt_Login.Text;
                usuAlterar.Nome = txt_Nome.Text;
                usuAlterar.Senha = txt_Senha.Text;
                usuAlterar.Status = checkBox_Status.Checked;

                appUsuario.Alterar(usuAlterar);
            }

            OrganizaCampos();
            CarregarGrid();
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            OrganizaCampos();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            UsuarioService appUsuario = new UsuarioService();
            usuarioBindingSource.DataSource = new List<Usuario>(appUsuario.ListarUsuarios());
            dataGridViewUsuario.DataSource = usuarioBindingSource;
        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsuario.CurrentRow == null)
            {
                MessageBox.Show("Usuário não selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var usuario = ((Usuario)dataGridViewUsuario.CurrentRow.DataBoundItem);
            ID.Text = usuario.Id.ToString();
            txt_Login.Text = usuario.Login;
            txt_Nome.Text = usuario.Nome;
            txt_Senha.Text = usuario.Senha;
            checkBox_Status.Checked = usuario.Status;
            txt_Senha.ReadOnly = true;
            btn_Update.Enabled = true;
            txt_Login.Focus();
        }

        private void OrganizaCampos()
        {
            txt_Nome.Text = string.Empty;
            txt_Login.Text = string.Empty;
            txt_Senha.Text = string.Empty;
            txt_Senha.ReadOnly = false;
            btn_Update.Enabled = false;
            ID.Text = string.Empty;
            txt_Nome.Focus();
        }

        private bool VerificaCampoVazio()
        {
            bool chave = txt_Login.Text == string.Empty || txt_Nome.Text == string.Empty || txt_Senha.Text == string.Empty;
            return chave;
        }

        #endregion Methods
    }
}