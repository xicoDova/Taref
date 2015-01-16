using System;
using System.Linq;
using System.Windows.Forms;
using Taref.Core.Classes;
using Taref.Service.Classes;
using Taref.Util.Classes;

namespace Taref.Main.Wins
{
    public partial class InitialWin : Form
    {
        #region Constructors

        public InitialWin()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void btn_Login_Click(object sender, EventArgs e)
        {
            UsuarioService appUsuario = new UsuarioService();

            if (ChecarBancoDeUsuarios())
            {
                var item = appUsuario.ListarUsuarios().Where(x => x.Login.Equals(txt_Login.Text) &&
                                                                           x.Senha.Equals(txt_Senha.Text) &&
                                                                           x.Status).ToList();

                if (item.Count > 0)
                {
                    PrincipalWin obj = new PrincipalWin();
                    var nome = item.Select(x => x.Nome);
                    classUtil.NomeDoUsuarioLogado = nome.SingleOrDefault();
                    obj.Show();
                    Visible = false;
                }

                else
                {
                    MessageBox.Show("Usuário não cadastrado ou Status encontra-se como Inativo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                OrganizaCampos();
            }

            else
            {
                Usuario aux = new Usuario();
                aux.Login = "prov";
                aux.Senha = "prov_123";
                aux.Nome = "Usuário provisório, por favor deletar";
                aux.Status = true;
                
                appUsuario.Salvar(aux);

                MessageBox.Show("Este é seu primeiro acesso, um usuário provisório foi criado. Conecte-se no sistema e delete este usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Login.Text = "prov";
                txt_Senha.Text = "prov_123";
            }
        }

        private void InitialWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void InitialWin_Load(object sender, EventArgs e)
        {
            OrganizaCampos();
        }

        private void OrganizaCampos()
        {
            txt_Login.Text = string.Empty;
            txt_Senha.Text = string.Empty;
            txt_Login.Focus();
        }

        private bool ChecarBancoDeUsuarios()
        {
            UsuarioService appUsuario = new UsuarioService();

            bool chave = appUsuario.ListarUsuarios().Count > 0;

            return chave;
        }

        #endregion Methods
    }
}