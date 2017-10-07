using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;
using Fifa.Proclube.Domains.Models.ViewModels;

namespace Fifa.Proclube.Domains.Repositorio
{
    public class ClubeRepository : BaseRepository<Clube>, IDisposable
    {
        public ClubeRepository(ProclubeContext context) : base(context)
        {

        }

        public void Dispose()
        {
            _context.Dispose();
        }


        public async Task<ClubeResumo> ObterClubeResumo(int JogadorID)
        {

            ClubeResumo _clube = new ClubeResumo();

            if (JogadorID <= 0)
                return _clube;


            _clube.Clube = new Clube();

            _clube.Clube = await this.ObterClube(JogadorID);

            _clube.Campeonatos = new List<Campeonato>();
            _clube.Campeonatos = await this.ObterCampeonatos(_clube.Clube.ClubeID);

            return _clube;

           }


        #region Metodos Privados

        private async Task<Clube> ObterClube(int JogadorID){

			Clube _clube = new Clube();

			if (JogadorID <= 0)
				return _clube;

            using(var ElencoRep = new ClubeElencoRepository(new ProclubeContext())){

                var elenco = await ElencoRep.FindAsync(s => s.JogadorID == JogadorID);
                _clube =  await this.GetAsync(elenco.CluebeID);

            }

            return _clube;

		}


		private async Task<List<Campeonato>> ObterCampeonatos(int ClubeID)
		{

            List<Campeonato> _campeonatos = new List<Campeonato>();

			if (ClubeID <= 0)
				return _campeonatos;

            List<ClubeCampeonato> listaCamp = new List<ClubeCampeonato>();

			using (var CampRep = new ClubeCampeonatoRepository(new ProclubeContext()))
			{
                var t = await CampRep.FindAllAsync(s => s.ClubeID == ClubeID);
                listaCamp = t.ToList();
			}


            _campeonatos = await this.ObterCampeonatosLista(listaCamp);


			return _campeonatos;
		}



		private async Task<List<Campeonato>> ObterCampeonatosLista ( List<ClubeCampeonato> clubeCampList)
		{

			List<Campeonato> _campeonatos = new List<Campeonato>();

			if (clubeCampList == null)
				return _campeonatos;



            foreach (var item in clubeCampList)
            {

                Campeonato camp = new Campeonato();

                camp = await this.ObterCampeonato(item.CampeonatoID);

                _campeonatos.Add(camp);
            }



            return _campeonatos;
		}



		private async Task<Campeonato> ObterCampeonato(int CampeonatoID)
		{

			Campeonato _campeonatos = new Campeonato();

			if (CampeonatoID <= 0)
				return _campeonatos;


			using (var CampRep = new CampeonatoRepositorio(new ProclubeContext()))
			{
                _campeonatos = await CampRep.GetAsync(CampeonatoID);
			}

			return _campeonatos;
		}


        #endregion
    }
}
