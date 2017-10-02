using System;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;
namespace Fifa.Proclube.Domains.Repositorio
{
    public class JogadorRepository:BaseRepository<Jogador>
    {
        public JogadorRepository(ProclubeContext context) : base(context)
        {
        }
    }
}
