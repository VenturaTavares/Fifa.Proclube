using System;
using System.Collections.Generic;

namespace Fifa.Proclube.Domains.Models.ViewModels
{
    public class UsuarioViewModel
    {

        public Usuario Usuario
        {
            get;
            set;
        }

        public List<Jogador> Jogadores
        {
            get;
            set;
        }

        public UsuarioViewModel()
        {
        }
    }
}
