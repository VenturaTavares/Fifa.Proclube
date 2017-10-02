using System;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;
namespace Fifa.Proclube.Domains.Repositorio
{
    public class ClubeRepository : BaseRepository<Clube>
    {
        public ClubeRepository(ProclubeContext context) : base(context)
        {

        }
    }
}
