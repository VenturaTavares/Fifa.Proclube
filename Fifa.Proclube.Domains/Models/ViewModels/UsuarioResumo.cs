using System;
using System.Collections.Generic;

namespace Fifa.Proclube.Domains.Models.ViewModels
{
    public class UsuarioResumo
    {

        public Usuario usuario { get; set; }

        public List<JogadorResumo> JogadoresResumo
        {
            get;
            set;
        }

    }
}
