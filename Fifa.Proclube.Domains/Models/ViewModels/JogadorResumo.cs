using System;
namespace Fifa.Proclube.Domains.Models.ViewModels
{
    public class JogadorResumo
    {

        public Jogador Jogaodr
        {
            get;
            set;
       
        }

        public Posicao Posicao
        {
            get;
            set;
        }


        public Estatisticas Estatisticas
        {
            get;
            set;
        }

        public Desenvolvimento Desenvolvimento
        {
            get;
            set;
        }

        public ClubeResumo ClubeResumo
        {
            get;
            set;
        }
    }
}


