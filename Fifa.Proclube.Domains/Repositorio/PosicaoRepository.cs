using System;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;

namespace Fifa.Proclube.Domains.Repositorio
{


	public class PosicaoRepository : BaseRepository<Posicao>
	{
		public PosicaoRepository(ProclubeContext context) : base(context)
		{

		}
	}
}
