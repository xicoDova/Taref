using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Taref.Core.Classes
{
    public class Categoria
    {
        #region Constructors

        public Categoria()
        {
            ListaTarefas = new Collection<Tarefa>();
        }

        #endregion Constructors

        #region Properties

        public string Descrição { get; set; }

        public int Id { get; set; }

        public virtual ICollection<Tarefa> ListaTarefas { get; set; }

        #endregion Properties

        #region Methods

        public void AddTarefas(Tarefa tarefa)
        {
            ListaTarefas.Add(tarefa);
        }

        public override string ToString()
        {
            return Descrição;
        }

        #endregion Methods
    }
}