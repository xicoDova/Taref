using System.Data.Entity;
using Taref.Core.Classes;
using Taref.Data.Mapping;

namespace Taref.Data.DataContexts
{
    public class dbTAREF : DbContext
    {
        #region Constructors

        public dbTAREF(): base("dbTAREF")
        { }
        #endregion Constructors

        #region Properties

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Tarefa> Tarefa { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        #endregion Properties

        #region Methods

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new TarefaMap());

            base.OnModelCreating(modelBuilder);
        }

        #endregion Methods
    }
}