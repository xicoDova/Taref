using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Taref.Core.Classes;
using Taref.Service.Classes;

namespace Taref.Main.Wins.Gerencia
{
    public partial class AcompanharTarefas : Form
    {
        #region Constructors

        public AcompanharTarefas()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void AcompanharTarefas_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            TarefaService appTarefa = new TarefaService();
            tarefaBindingSource.DataSource = new List<Tarefa>(appTarefa.ListarTarefas());
            dataGridViewTarefa.DataSource = tarefaBindingSource;
        }

        #endregion Methods

        private void btn_Check_Click(object sender, EventArgs e)
        { Checar(); }

        private void Checar()
        {
            int tarAtrasadas = 0;
            int tarDeHoje = 0;
            int tarAndamento = 0;
            int tarFinalizada = 0;
            int tarFechada = 0;

            for (int i = 0; i < dataGridViewTarefa.RowCount; i++)
            {
                var data = ((Tarefa)dataGridViewTarefa.Rows[i].DataBoundItem).Termino;
                var situação = ((Tarefa)dataGridViewTarefa.Rows[i].DataBoundItem).Situação;

                if (situação == 0)
                {
                    tarFechada++;
                    dataGridViewTarefa.Rows[i].DefaultCellStyle.BackColor = Color.Empty;
                }

                if (situação == 1 && data.Date == DateTime.Now.Date)
                {
                    tarAndamento++;
                    tarDeHoje++;
                    dataGridViewTarefa.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }

                if (situação == 1 && data.Date < DateTime.Now.Date)
                {
                    tarAndamento++;
                    tarAtrasadas++;
                    dataGridViewTarefa.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                }

                if (situação == 1 && data.Date > DateTime.Now.Date)
                {
                    tarAndamento++;
                    dataGridViewTarefa.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                }

                if (situação == 2)
                {
                    tarFinalizada++;
                    dataGridViewTarefa.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }

            MessageBox.Show("Existem " + tarDeHoje + " tarefas para hoje", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Existem " + tarAtrasadas + " tarefas atrasadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Existem " + tarAndamento + " tarefas em andamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Existem " + tarFechada + " tarefas fechadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Existem " + tarFinalizada + " tarefas finalizadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}