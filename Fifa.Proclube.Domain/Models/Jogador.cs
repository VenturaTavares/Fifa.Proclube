using System;
namespace Fifa.Proclube.Domain.Models
{
    public class Jogador
    {
        public Jogador()
        {

			this.DataRegistro = DateTime.Now;
        }



		public int JogadorID
		{
			get;
			set;
		}

		public int PosicaoID
		{
			get;
			set;
		}

        public int NacionalidadeID
        {
            get;
            set;
        }


		public string Nome
		{
			get;
			set;

		}

		public double Altura
		{
			get;
			set;
		}

		public double Peso
		{
			get;
			set;
		}

		public DateTime DataRegistro
		{
			get;
			set;
		}


		public byte FotoProfile
		{
			get;
			set;
		}
    }
}
