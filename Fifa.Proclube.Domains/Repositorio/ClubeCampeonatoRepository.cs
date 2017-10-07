using System;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;

namespace Fifa.Proclube.Domains.Repositorio
{
    public class ClubeCampeonatoRepository : BaseRepository<ClubeCampeonato>, IDisposable
    {
        public ClubeCampeonatoRepository(ProclubeContext context) : base(context)
        {
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
