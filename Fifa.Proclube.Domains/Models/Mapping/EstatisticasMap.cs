using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Fifa.Proclube.Domains.Models.Mapping
{
    public class EstatisticasMap : EntityTypeConfiguration<Estatisticas>
    {
        public EstatisticasMap()
        {

            this.HasKey(t => t.EstatisticaID);

            // Properties

            // Table & Column Mappings
            this.ToTable("Estatisticas");
            this.Property(t => t.EstatisticaID).HasColumnName("EstatisticaID").HasColumnType("bigint");
            this.Property(t => t.Classificacao).HasColumnName("Classificacao").HasColumnType("float");
            this.Property(t => t.Assistencias).HasColumnName("Assistencias").HasColumnType("int");
            this.Property(t => t.Finalizacoes).HasColumnName("Finalizacoes").HasColumnType("int");
            this.Property(t => t.Gols).HasColumnName("Gols").HasColumnType("int");
            this.Property(t => t.JogadorID).HasColumnName("JogadorID").HasColumnType("bigint");
            this.Property(t => t.MelhorEmCampo).HasColumnName("MelhorEmCampo").HasColumnType("int");
            this.Property(t => t.PartidasDisputadas).HasColumnName("PartidasDisputadas").HasColumnType("int");

        }

    }

}
