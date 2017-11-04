using System;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;
namespace Fifa.Proclube.Domains.Repositorio
{
    public class EstatisticasRepository:BaseRepository<Estatisticas>, IDisposable
    {
        public EstatisticasRepository(ProclubeContext context) : base(context)
        {
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
