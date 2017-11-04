using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;
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


        public async Task<Clube> ObterClube(int ClubeID)
        {

            Clube clube = new Clube();

            if (ClubeID <= 0)
                return clube;


            clube.ClubeID = 1;
            clube.Descricao = "Selecao brasileira";

            return clube;
        
        }


        public async Task<List<Jogador>> ObterElenco(int ClubeID)
        {

            List<Jogador> Elenco = new List<Jogador>();

            if (ClubeID <= 0)
                return Elenco;


            using (var Rep = new JogadorRepository(new ProclubeContext())){

                Elenco = await   Rep.ObterTime(ClubeID);
            }
         

            return Elenco;

        }



        public async Task<List<Clube>> ObterClubesCampeonato(int ClubeID)
        {

            List<Clube> Clubes = new List<Clube>();

            if (ClubeID <= 0)
                return Clubes;


            using (var Rep = new JogadorRepository(new ProclubeContext()))
            {

                Clubes = await MontarClubesCampeonato();
            }


            return Clubes;

        }



        public async Task<List<Clube>> MontarClubesCampeonato()
        {

            List<Clube> ListaClubes = new List<Clube>();

            Clube clube1 = new Clube();
            Clube clube2 = new Clube();
            Clube clube3 = new Clube();
            Clube clube4 = new Clube();
            Clube clube5 = new Clube();
            Clube clube6 = new Clube();

            clube1.ClubeID = 1;
            clube1.Nome = "Sao Paulo";
            clube1.Descricao = "Sao Paulo";

            ListaClubes.Add(clube1);

            clube2.ClubeID = 2;
            clube2.Nome = "Atletico MG";
            clube2.Descricao = "Atletico MG";

            ListaClubes.Add(clube2);

            clube3.ClubeID = 3;
            clube3.Nome = "Flamengo";
            clube3.Descricao = "Flamengo";

            ListaClubes.Add(clube3);
        

            clube4.ClubeID = 4;
            clube4.Nome = "Gremio";
            clube4.Descricao = "Gremio";

            ListaClubes.Add(clube4);
        


            clube5.ClubeID = 5;
            clube5.Nome = "Sport";
            clube5.Descricao = "Sport";

            ListaClubes.Add(clube5);


            clube6.ClubeID = 6;
            clube6.Nome = "Avai";
            clube6.Descricao = "Avai";

            ListaClubes.Add(clube6);

            return ListaClubes;

        }


    }
}
