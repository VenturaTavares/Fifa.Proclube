using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Fifa.Proclube.Domains.Models;

namespace Fifa.Proclube.API.Models
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel()
        {
        }


        public int UsuarioID
        {
            get;
            set;

        }

        [Required]
        public string Nome
        {
            get;
            set;

        }

        [Required]
        public string NickName
        {
            get;
            set;
        }

        [Required]
        public string CodigoPsn
        {
            get;
            set;
        }

        public DateTime DataRegistro
        {
            get;
            set;
        }

        [Required]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email
        {
            get;
            set;

        }

        [Required]
        [Remote("ValidarCPF", "Validacao")]
        public string CPF
        {
            get;
            set;
        }

        [Required]
        [MinLength(8, ErrorMessage = "Mínimo 8 caracteres")]
        public string Senha
        {
            get;
            set;
        }

        public byte FotoProfile
        {
            get;
            set;
        }

        public List<Jogador> Jogadores { get; set}

    }

	
}
