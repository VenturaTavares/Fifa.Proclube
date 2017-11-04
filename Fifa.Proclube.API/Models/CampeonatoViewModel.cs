using System;
using System.ComponentModel.DataAnnotations;

namespace Fifa.Proclube.API.Models
{
    public class CampeonatoViewModel
    {


        public CampeonatoViewModel()
        {
            this.DataRegistro = DateTime.Now;
        }

        public int CampeonatoID
        {
            get;
            set;

        }


        [Required(ErrorMessage = "Nome Campeonato é obrigatório")]
        public string Nome
        {
            get;
            set;

        }

        [Required(ErrorMessage = "Descricao é obrigatório")]
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
    }
}
