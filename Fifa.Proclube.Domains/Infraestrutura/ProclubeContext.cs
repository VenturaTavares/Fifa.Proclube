using Fifa.Proclube.Domains.Models;
using Fifa.Proclube.Domains.Models.Mapping;
using System.Data.Entity;

namespace Fifa.Proclube.Domains.Infraestrutura
{
    public class ProclubeContext : DbContext
    {

        static ProclubeContext()
        {
            Database.SetInitializer<ProclubeContext>(null);
        }

        public ProclubeContext()
                : base("Name=ProclubeDBContext")
        {
        }
        public DbSet<Campeonato> Campeonato { get; set; }
        public DbSet<Clube> Clube { get; set; }
        public DbSet<ClubeCampeonato> ClubeCampeonato { get; set; }
        public DbSet<ClubeContratando> ClubeContratando { get; set; }
        public DbSet<ClubeElenco> ClubeElenco { get; set; }
        public DbSet<Desenvolvimento> Desenvolvimento { get; set; }
        public DbSet<Estatisticas> Estatisticas { get; set; }
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Posicao> Posicao { get; set; }
        public DbSet<Usuario> Usuario { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CampeonatoMap());
            modelBuilder.Configurations.Add(new ClubeCampeonatoMap());
            modelBuilder.Configurations.Add(new ClubeContratandoMap());
            modelBuilder.Configurations.Add(new ClubeElencoMap());
            modelBuilder.Configurations.Add(new ClubeMap());
            modelBuilder.Configurations.Add(new DesenvolvimentoMap());
            modelBuilder.Configurations.Add(new EstatisticasMap());
            modelBuilder.Configurations.Add(new JogaodorMap());
            modelBuilder.Configurations.Add(new PosicaoMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}
