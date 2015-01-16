using System.Data.Entity.ModelConfiguration;
using Taref.Core.Classes;

namespace Taref.Data.Mapping
{
    public class TarefaMap : EntityTypeConfiguration<Tarefa>
    {
        #region Constructors

        public TarefaMap()
        {
            ToTable("Tarefa");

            HasKey(x => x.Id);

            Property(x => x.Descrição).HasMaxLength(30).IsOptional();
            Property(x => x.Titulo).HasMaxLength(10).IsRequired();
            Property(x => x.Prioridade).IsRequired();
            Property(x => x.Inicio).IsRequired();
            Property(x => x.Termino).IsRequired();
            Property(x => x.Situação).IsRequired();

            HasRequired(x => x.Categoria);
            HasRequired(x => x.Responsavel);
        }

        #endregion Constructors
    }
}