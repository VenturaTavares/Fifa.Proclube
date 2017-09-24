using System;

namespace Fifa.Proclube.Domain.Models
{
    public class Usuario
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

        public string Email
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


    }
}
