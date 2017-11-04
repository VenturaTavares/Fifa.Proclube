using System;
using System.Linq;
using System.Threading.Tasks;
using Fifa.Proclube.Domains.Common;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;


namespace Fifa.Proclube.Domains.Repositorio
{

	public class UsuarioRepository : BaseRepository<Usuario>, IDisposable
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

       

        public Usuario MontarUsuario()
        {

            Usuario UserFake = new Usuario();

            UserFake.CodigoPsn = "123456789";
            UserFake.CPF = "123456789";
            UserFake.DataRegistro = DateTime.Now;
            UserFake.Email = "Teste@teste.com";
            UserFake.NickName = "UserFake.NickName";
            UserFake.Nome = "UserFake.Nome";
            UserFake.Senha = "UserFake.Senha";
            UserFake.UsuarioID = 1;

            return UserFake;
        }


        public void Dispose()
        {
            _context.Dispose();
        }


	}
}
