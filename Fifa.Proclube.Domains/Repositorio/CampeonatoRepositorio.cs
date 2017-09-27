
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;

namespace Fifa.Proclube.Domains.Repositorio
{
    public class CampeonatoRepositorio : BaseRepository<Campeonato>
    {
        public CampeonatoRepositorio(ProclubeContext context) : base(context)
        {

        }
    }


}
