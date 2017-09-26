using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace Fifa.Proclube.Domains.Models.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {


        public UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.UsuarioID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Usuario");
            this.Property(t => t.UsuarioID).HasColumnName("UsuarioID").HasColumnType("bigint(20)");
            this.Property(t => t.Nome).HasColumnName("Nome").HasColumnType("nvarchar(200)");
            this.Property(t => t.Senha).HasColumnName("Senha").HasColumnType("nvarchar(200)");
            this.Property(t => t.NickName).HasColumnName("NickName").HasColumnType("nvarchar(200)");
            this.Property(t => t.CPF).HasColumnName("CPF").HasColumnType("nvarchar(100)");
            this.Property(t => t.DataRegistro).HasColumnName("DataRegistro").HasColumnType("smalldatetime");
            this.Property(t => t.Email).HasColumnName("Email").HasColumnType("nvarchar(200)");
            this.Property(t => t.CodigoPsn).HasColumnName("CodigoPsn").HasColumnType("nvarchar(200)");
            this.Property(t => t.FotoProfile).HasColumnName("FotoProfile").HasColumnType("byte");
        }
    }
}
