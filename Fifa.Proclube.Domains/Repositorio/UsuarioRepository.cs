using System;
using System.Linq;
using System.Threading.Tasks;
using Fifa.Proclube.Domains.Common;
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


     
        public async Task<Usuario> AutenticarUsuario(string usuario ,string senha){



            
            Usuario _usuario = new Usuario();

            bool UsuarioAutenticado = false;

            var UsuarioNome = await this.FindAsync(s => s.NickName.ToLower() == usuario.ToLower());

             UsuarioAutenticado = Encryption.Decrypt(UsuarioNome.Senha) == senha;

            if (UsuarioAutenticado)
                _usuario = UsuarioNome;
                        

            return _usuario;
                
        }



	}
}
