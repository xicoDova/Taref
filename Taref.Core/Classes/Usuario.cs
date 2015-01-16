using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Taref.Core.Classes
{
    public class Usuario
    {
        #region Constructors

        public Usuario()
        {
            ListaTarefas = new Collection<Tarefa>();
        }

        #endregion Constructors

        #region Properties

        public int Id { get; set; }

        public virtual ICollection<Tarefa> ListaTarefas { get; set; }

        public string Login { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public bool Status { get; set; }

        #endregion Properties

        #region Methods

        public void AddTarefas(Tarefa tarefa)
        {
            ListaTarefas.Add(tarefa);
        }

        public override string ToString()
        {
            return Nome;
        }

        #endregion Methods
    }
}