using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Fifa.Proclube.Domains.Models
{
    public class Usuario : IdentityUser
    {
        public Usuario()
        {

            this.DataRegistro = DateTime.Now;
        }


        public int UsuarioID
        {
            get;
            set;

        }

        public string Nome
        {
            get;
            set;

        }

        public string NickName
        {
            get;
            set;
        }

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

   

        public string CPF
        {
            get;
            set;
        }

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

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Usuario> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            userIdentity.AddClaim(new Claim("Nome", this.NickName));

            // Add custom user claims here
            return userIdentity;
        }
    }
}
