using System;
namespace Fifa.Proclube.Domain.Models
{
    public class Estatisticas
    {
        public Estatisticas()
        {
        }


        public int EstatisticaID
        {
            get;
            set;
        }

		public int JogadorID
		{
			get;
			set;
		}

		public int PartidasDisputadas
		{
			get;
			set;
		}

		public int Gols
		{
			get;
			set;
		}

		public int Assistencias
		{
			get;
			set;
		}


		public int Finalizacoes
		{
			get;
			set;
		}

		public int MelhorEmCampo
		{
			get;
			set;
		}

        public double Classificacao
		{
			get;
			set;
		}
    }
}
