using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Fifa.Proclube.Domains.Models.Mapping
{
    public class CampeonatoMap : EntityTypeConfiguration<Campeonato>
    {

        public CampeonatoMap()
        {
            this.HasKey(t => t.CampeonatoID);

            // Properties

            // Table & Column Mappings
            this.ToTable("Campeonato");
            this.Property(t => t.CampeonatoID).HasColumnName("CampeonatoID").HasColumnType("int");
            this.Property(t => t.DataFim).HasColumnName("DataFim").HasColumnType("smalldatetime");
            this.Property(t => t.DataInicio).HasColumnName("DataInicio").HasColumnType("smalldatetime");
            this.Property(t => t.DataRegistro).HasColumnName("DataRegistro").HasColumnType("smalldatetime");
            this.Property(t => t.Descricao).HasColumnName("Descricao").HasColumnType("longvarchar(200)");
            this.Property(t => t.Nome).HasColumnName("Nome").HasColumnType("longvarchar(200)");
        }
    }
}
