using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;


namespace Fifa.Proclube.API.App_Start
{
	public class ApplicationUserManager : UserManager<Usuario>
	{
		public ApplicationUserManager(IUserStore<Usuario> store)
			: base(store)
		{
		}

		public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
		{

            var manager = new ApplicationUserManager(new UserStore<Usuario>(new ProclubeContext()));
			// Configurar a lógica de validação para nomes de usuário
			manager.UserValidator = new UserValidator<Usuario>(manager)
			{
				AllowOnlyAlphanumericUserNames = false,
				RequireUniqueEmail = true
			};
			// Configurar a lógica de validação para senhas
			manager.PasswordValidator = new PasswordValidator
			{
				RequiredLength = 6,
				RequireNonLetterOrDigit = true,
				RequireDigit = true,
				RequireLowercase = true,
				RequireUppercase = true,
			};
			var dataProtectionProvider = options.DataProtectionProvider;
			if (dataProtectionProvider != null)
			{
				manager.UserTokenProvider = new DataProtectorTokenProvider<Usuario>(dataProtectionProvider.Create("ASP.NET Identity"));
			}
			return manager;
		}
	}
}
