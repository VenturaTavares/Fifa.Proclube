using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Fifa.Proclube.Domains.Models.Mapping
{
    public class ClubeCampeonatoMap : EntityTypeConfiguration<ClubeCampeonato>
    {
        public ClubeCampeonatoMap()
        {
            this.HasKey(t => t.ClubeCampeonatoID);

            // Properties

            // Table & Column Mappings
            this.ToTable("ClubeCampeonato");
            this.Property(t => t.ClubeCampeonatoID).HasColumnName("ClubeCampeonatoID").HasColumnType("int");
            this.Property(t => t.ClubeID).HasColumnName("ClubeID").HasColumnType("int");
            this.Property(t => t.CampeonatoID).HasColumnName("CampeonatoID").HasColumnType("int");
        }
    }
}
