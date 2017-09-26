using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Fifa.Proclube.Domains.Models.Mapping
{
    public class ClubeContratandoMap : EntityTypeConfiguration<ClubeContratando>
    {

        public ClubeContratandoMap()
        {
            this.HasKey(t => t.ClubeContratadoID);

            // Properties

            // Table & Column Mappings
            this.ToTable("ClubeContratando");
            this.Property(t => t.ClubeContratadoID).HasColumnName("ClubeContratadoID").HasColumnType("int");
            this.Property(t => t.ClubeID).HasColumnName("ClubeID").HasColumnType("int");
            this.Property(t => t.PosicaoID).HasColumnName("PosicaoID").HasColumnType("int");
            this.Property(t => t.Contratado).HasColumnName("Contratado").HasColumnType("boolean");


        }
    }
}
