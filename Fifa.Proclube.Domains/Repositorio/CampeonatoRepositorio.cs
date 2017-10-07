
using System;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;

namespace Fifa.Proclube.Domains.Repositorio
{
    public class CampeonatoRepositorio : BaseRepository<Campeonato> ,  IDisposable
    {
        public CampeonatoRepositorio(ProclubeContext context) : base(context)
        {

        }

        public void Dispose()
        {
          _context.Dispose();
        }
    }


}
