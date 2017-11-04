using System;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;
namespace Fifa.Proclube.Domains.Repositorio
{
    public class DesenvolvimentoRepository : BaseRepository<Desenvolvimento>, IDisposable
    {
        public DesenvolvimentoRepository(ProclubeContext context) : base(context)
        {
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
