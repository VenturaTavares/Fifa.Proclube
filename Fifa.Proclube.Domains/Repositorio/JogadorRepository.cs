using System;
using System.Threading.Tasks;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;
using Fifa.Proclube.Domains.Models.ViewModels;

namespace Fifa.Proclube.Domains.Repositorio
{
    public class JogadorRepository : BaseRepository<Jogador>, IDisposable
    {
        public JogadorRepository(ProclubeContext context) : base(context)
        {
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<JogadorResumo> ObterJogadorResumo(int JogadorID)
        {

            JogadorResumo jogadorResumo = new JogadorResumo();

            if (JogadorID <= 0)
                return jogadorResumo;

            jogadorResumo.Desenvolvimento = new Desenvolvimento();
            jogadorResumo.Desenvolvimento = await this.ObterDesenvolvimento(JogadorID);

            jogadorResumo.Estatisticas = new Estatisticas();
            jogadorResumo.Estatisticas = await this.ObterEstatistica(JogadorID);

            jogadorResumo.Posicao = new Posicao();
            jogadorResumo.Posicao = await this.ObterPosicao(JogadorID);

            jogadorResumo.ClubeResumo = new ClubeResumo();
            jogadorResumo.ClubeResumo = await this.ObterClubeResumo(JogadorID);


            return jogadorResumo;

        }

        #region Metodos Privados

        private async Task<Desenvolvimento> ObterDesenvolvimento(int JogadorID)
        {

            Desenvolvimento desenv = new Desenvolvimento();

            if (JogadorID <= 0)
                return desenv;


            using (var DesenvolvimenteRep = new DesenvolvimentoRepository(new ProclubeContext()))
            {

                desenv = await DesenvolvimenteRep.FindAsync(s => s.JogadorID == JogadorID);

            }

            return desenv;

        }

        private async Task<Estatisticas> ObterEstatistica(int JogadorID)
        {

            Estatisticas estatistca = new Estatisticas();

            if (JogadorID <= 0)
                return estatistca;


            using (var EstatRep = new EstatisticasRepository(new ProclubeContext()))
            {

                estatistca = await EstatRep.FindAsync(s => s.JogadorID == JogadorID);

            }

            return estatistca;

        }

        private async Task<Posicao> ObterPosicao(int JogadorID)
        {

            Posicao posicao = new Posicao();

            if (JogadorID <= 0)
                return posicao;


            using (var PosiRep = new PosicaoRepository(new ProclubeContext()))
            {

                posicao = await this.ObterPosicao(JogadorID);

            }

            return posicao;

        }

        private async Task<ClubeResumo> ObterClubeResumo(int JogadorID){

            ClubeResumo cResumo = new ClubeResumo();

            if (JogadorID <= 0)
                return cResumo;

			using (var ClubeRep = new ClubeRepository(new ProclubeContext()))
			{

                cResumo = await ClubeRep.ObterClubeResumo(JogadorID);

			}

            return cResumo;

        }
#endregion 
    }
}
