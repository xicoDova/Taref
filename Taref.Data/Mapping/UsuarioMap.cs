using System.Data.Entity.ModelConfiguration;
using Taref.Core.Classes;

namespace Taref.Data.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        #region Constructors

        public UsuarioMap()
        {
            ToTable("Usuario");

            HasKey(x => x.Id);

            Property(x => x.Login).HasMaxLength(10).IsRequired();
            Property(x => x.Nome).HasMaxLength(180).IsRequired();
            Property(x => x.Senha).HasMaxLength(8).IsRequired();
            Property(x => x.Status).IsRequired();
        }

        #endregion Constructors
    }
}