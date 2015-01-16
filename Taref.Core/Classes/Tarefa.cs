using System;

namespace Taref.Core.Classes
{
    public class Tarefa
    {
        #region Properties

        public Categoria Categoria { get; set; }

        public string Descrição { get; set; }

        public int Id { get; set; }

        public int Prioridade { get; set; }// De 0 até 10

        public Usuario Responsavel { get; set; }

        public string Titulo { get; set; }

        public int Situação { get; set; }// 0-Fechada || 1-Em andamento || 2-Finalizada

        public DateTime Inicio { get; set; }

        public DateTime Termino { get; set; }

        #endregion Properties
    }
}