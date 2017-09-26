using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Fifa.Proclube.Domains.Models.Mapping
{
   public class DesenvolvimentoMap : EntityTypeConfiguration<Desenvolvimento>
    {

        public DesenvolvimentoMap()
        {
            this.HasKey(t => t.DesenvolvimentoID);
            // Properties
            // Table & Column Mappings
            this.ToTable("Desenvolvimento");

            this.Property(t => t.DesenvolvimentoID).HasColumnName("DesenvolvimentoID").HasColumnType("bigint");
            this.Property(t => t.Defesa).HasColumnName("Defesa").HasColumnType("int");
            this.Property(t => t.Drible).HasColumnName("Drible").HasColumnType("int");
            this.Property(t => t.Finalizacao).HasColumnName("Finalizacao").HasColumnType("int");
            this.Property(t => t.Fisico).HasColumnName("Fisico").HasColumnType("int");
            this.Property(t => t.Goleiro).HasColumnName("Goleiro").HasColumnType("int");
            this.Property(t => t.JogadorID).HasColumnName("JogadorID").HasColumnType("bigint");
            this.Property(t => t.Passe).HasColumnName("Passe").HasColumnType("int");
            this.Property(t => t.Ritmo).HasColumnName("Ritmo").HasColumnType("int");
        }
    }
}
