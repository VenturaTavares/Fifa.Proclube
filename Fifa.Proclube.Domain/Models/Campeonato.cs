using System;
namespace Fifa.Proclube.Domain.Models
{
    public class Campeonato
    {
        public Campeonato()
        {
            this.DataRegistro = DateTime.Now;    
        }

        public int CampeonatoID
        {
            get;
            set;
        
        }

        public string Nome
        {
            get;
            set;
   
        }

		public string Descricao
		{
			get;
			set;
		}

		public DateTime  DataRegistro
		{
			get;
			set;
		}

		public DateTime DataInicio
		{
			get;
			set;
		}

		public DateTime DataFim
		{
			get;
			set;
		}


		public int NacionalidadeID
		{
			get;
			set;
		}
    }
}
