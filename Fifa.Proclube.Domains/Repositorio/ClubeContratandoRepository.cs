using System;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;
namespace Fifa.Proclube.Domains.Repositorio
{
    public class ClubeContratandoRepository:BaseRepository<ClubeContratando>
    {
        public ClubeContratandoRepository(ProclubeContext context) : base(context)
        {
        }
    }
}
