using System;
using System.Threading.Tasks;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;

namespace Fifa.Proclube.Domains.Repositorio
{


    public class PosicaoRepository : BaseRepository<Posicao>, IDisposable
	{
		public PosicaoRepository(ProclubeContext context) : base(context)
		{

		}

        public void Dispose()
        {
            _context.Dispose();
        }


        public async Task<Posicao> ObterPosicao (int PosicaoID){
            
            Posicao Posicao = new Posicao();
            if (PosicaoID == 0)
                return Posicao;


            Posicao.PosicaoID = PosicaoID;

            Posicao.Descricao = "Atacante";


            return Posicao;

        }
	}
}
