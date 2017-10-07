using System;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;
namespace Fifa.Proclube.Domains.Repositorio
{
    public class ClubeElencoRepository : BaseRepository<ClubeElenco>,IDisposable
    {
        public ClubeElencoRepository(ProclubeContext context) : base(context)
        {
        }

        public void Dispose()
        {
          _context.Dispose();
        }
    }
}
