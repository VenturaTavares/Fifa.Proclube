using System;
using System.Linq;
using System.Threading.Tasks;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;
using Fifa.Proclube.Domains.Models.ViewModels;

namespace Fifa.Proclube.Domains.Repositorio
{

	public class UsuarioRepository : BaseRepository<Usuario>
	{
		public UsuarioRepository(ProclubeContext context) : base(context)
		{

		}


        public Task<UsuarioViewModel> ObterUsuario(int UsuarioID) {

            UsuarioViewModel usuario = new UsuarioViewModel();

            list<

            var rep = new JogadorRepository(new ProclubeContext());


            usuario.Jogadores =  await rep.FindAllAsync(s=>s.)

        
        
        }



        }
	}
}
