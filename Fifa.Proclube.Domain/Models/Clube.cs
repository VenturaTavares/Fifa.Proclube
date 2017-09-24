using System;
namespace Fifa.Proclube.Domain.Models
{
    public class Clube
    {
        public Clube()
        {

            this.DataRegistro = DateTime.Now;
        }

        public int ClubeID
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

        public DateTime DataRegistro
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
