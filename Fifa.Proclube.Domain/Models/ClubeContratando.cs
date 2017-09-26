using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa.Proclube.Domain.Models
{
    public class ClubeContratando
    {

        public int ClubeContratadoID { get; set; }

        public int ClubeID { get; set; }

        public int PosicaoID { get; set; }

        public bool Contratado { get; set; }

    }
}
