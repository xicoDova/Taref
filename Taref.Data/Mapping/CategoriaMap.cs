using System.Data.Entity.ModelConfiguration;
using Taref.Core.Classes;

namespace Taref.Data.Mapping
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        #region Constructors

        public CategoriaMap()
        {
            ToTable("Categoria");

            HasKey(x => x.Id);

            Property(x => x.Descrição).HasMaxLength(15).IsRequired();
        }

        #endregion Constructors
    }
}