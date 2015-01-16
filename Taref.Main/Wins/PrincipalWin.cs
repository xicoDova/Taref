using System;
using System.Windows.Forms;
using Taref.Main.Wins.CRUD_Categoria;
using Taref.Main.Wins.CRUD_Tarefa;
using Taref.Main.Wins.CRUD_Usuario;
using Taref.Main.Wins.Gerencia;
using Taref.Util.Classes;

namespace Taref.Main.Wins
{
    public partial class PrincipalWin : Form
    {
        public PrincipalWin()
        {
            InitializeComponent(); 
        }

        private void PrincipalWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            InitialWin obj = new InitialWin();
            obj.Visible = true;
        }

        private void adicionarUsuárioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            CadastroUsuario obj = new CadastroUsuario();
            obj.MdiParent = this;
            obj.Show();
        }

        private void consultarUsuárioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ConsultarUsuário obj = new ConsultarUsuário();
            obj.MdiParent = this;
            obj.Show();
        }

        private void adicionarCategoriaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            CadastroCategoria obj = new CadastroCategoria();
            obj.MdiParent = this;
            obj.Show();
        }

        private void consultarCategoriaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ConsultarCategoria obj = new ConsultarCategoria();
            obj.MdiParent = this;
            obj.Show();
        }

        private void adicionarTarefaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            CadastroTarefa obj = new CadastroTarefa();
            obj.MdiParent = this;
            obj.Show();
        }

        private void consultarTarefaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ConsultaTarefas obj = new ConsultaTarefas();
            obj.MdiParent = this;
            obj.Show();
        }

        private void acompanharTarefasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AcionarLembrete();
        }

        private void PrincipalWin_Load(object sender, System.EventArgs e)
        {
            AcionarLembrete();
        }

        private void AcionarLembrete()
        {
            AcompanharTarefas obj = new AcompanharTarefas();
            obj.MdiParent = this;
            obj.Show();
            Logado.Text = "Bem-Vindo " + classUtil.NomeDoUsuarioLogado;
            Data.Text = "Data atual: " + DateTime.Now.ToLongDateString().ToUpper();
        }
    }
}