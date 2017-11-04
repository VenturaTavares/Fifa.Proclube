using System;
namespace Fifa.Proclube.Domains.Models
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


        public int UsuarioID
        {
            get;
            set;
        }

		public int PosicaoID
		{
			get;
			set;
		}

        public virtual Posicao Posicao
        {
            get;
            set;
        }

        public virtual Usuario Usuario
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
