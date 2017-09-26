using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Fifa.Proclube.Domains.Models.Mapping
{
    public class ClubeMap : EntityTypeConfiguration<Clube>
    {


        public ClubeMap()
        {
            this.HasKey(t => t.ClubeID);

            // Properties

            // Table & Column Mappings
            this.ToTable("Clube");
            this.Property(t => t.ClubeID).HasColumnName("ClubeID").HasColumnType("int");

            this.Property(t => t.DataRegistro).HasColumnName("DataRegistro").HasColumnType("smalldatetime");
            this.Property(t => t.Descricao).HasColumnName("Descricao").HasColumnType("longvarchar(100)");
            this.Property(t => t.Nome).HasColumnName("Nome").HasColumnType("longvarchar(100)");
        }

   
    }
}
