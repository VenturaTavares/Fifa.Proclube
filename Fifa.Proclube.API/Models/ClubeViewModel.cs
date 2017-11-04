using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Fifa.Proclube.Domains.Models;

namespace Fifa.Proclube.API.Models
{
    public class ClubeViewModel
    {
        public ClubeViewModel()
        {

            this.DataRegistro = DateTime.Now;
        }

        public int ClubeID
        {
            get;
            set;

        }


        [Required(ErrorMessage = "Nome do Time é obrigatório")]
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

        public List<Jogador> Jogadores
        {
            get;
            set;
        }

    }
}
