using System;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;
namespace Fifa.Proclube.Domains.Repositorio
{
    public class EstatisticasRepository:BaseRepository<Estatisticas>
    {
        public EstatisticasRepository(ProclubeContext context) : base(context)
        {
        }
    }
}
