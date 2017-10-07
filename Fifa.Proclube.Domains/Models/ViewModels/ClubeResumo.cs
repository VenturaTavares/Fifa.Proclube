using System;
using System.Collections.Generic;

namespace Fifa.Proclube.Domains.Models.ViewModels
{
    public class ClubeResumo
    {

        public Clube Clube
        {
            get;
            set;
        }

        public List<Campeonato> Campeonatos
        {
            get;
            set;
        }

        public List<JogadorResumo> JogadoresResumo
        {
            get;
            set;
        }
    }
}
