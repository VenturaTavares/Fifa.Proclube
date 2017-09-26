using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Fifa.Proclube.Domains.Models.Mapping
{
    public class JogaodorMap : EntityTypeConfiguration<Jogador>
    {

        public JogaodorMap()
        {
            // Primary Key
            this.HasKey(t => t.JogadorID);

            // Properties

            // Table & Column Mappings
            this.ToTable("Jogaodor");
            this.Property(t => t.JogadorID).HasColumnName("JogadorID").HasColumnType("bigint");
            this.Property(t => t.Nome).HasColumnName("Nome").HasColumnType("longvarchar");
            this.Property(t => t.Peso).HasColumnName("Peso").HasColumnType("float");
            this.Property(t => t.Altura).HasColumnName("Altura").HasColumnType("float");
            this.Property(t => t.DataRegistro).HasColumnName("DataRegistro").HasColumnType("smalldatetine");
            this.Property(t => t.FotoProfile).HasColumnName("FotoProfile").HasColumnType("longvarbinary");
            this.Property(t => t.PosicaoID).HasColumnName("PosicaoID").HasColumnType("int");
        }
    }
}
