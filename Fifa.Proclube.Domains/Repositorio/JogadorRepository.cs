using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fifa.Proclube.Domains.Infraestrutura;
using Fifa.Proclube.Domains.Models;
namespace Fifa.Proclube.Domains.Repositorio
{
    public class JogadorRepository:BaseRepository<Jogador>, IDisposable
    {
        public JogadorRepository(ProclubeContext context) : base(context)
        {
        }

        public void Dispose()
        {
            _context.Dispose();
        }


        public async Task<Jogador> ObterJogador(int JogadorID){


            Jogador Jogador = new Jogador();


            Jogador.DataRegistro = DateTime.Now;
            Jogador.Altura = 1.85;
            Jogador.JogadorID = 1;
            Jogador.Nome =  "Ventura";
            Jogador.Peso = 90;
            Jogador.PosicaoID = 1;
            Jogador.UsuarioID = 1;
            Jogador.Usuario = await this.ObterUsuario(Jogador.UsuarioID);
            Jogador.Posicao = await this.ObterPosicao(Jogador.PosicaoID);

            return Jogador;


        }



        public async Task<Usuario> ObterUsuario(int UsuarioID)
        {
            Usuario user = new Usuario(); 

            using(var Rep = new UsuarioRepository(new ProclubeContext())){

                user =   Rep.MontarUsuario();

            }

            return user;
        }

        public async Task<Posicao> ObterPosicao(int PosicaoID)
        {
            Posicao Posicao = new Posicao();

            using (var Rep = new PosicaoRepository(new ProclubeContext()))
            {

                Posicao = await Rep.ObterPosicao(PosicaoID);

            }

            return Posicao;


        }



        public async Task<List<Jogador>> ObterTime(int PosicaoID)
        {
            List<Jogador> Jogadores = new List<Jogador>();

        
        


            Jogador Jogador = new Jogador();


            Jogador.DataRegistro = DateTime.Now;
            Jogador.Altura = 1.85;
            Jogador.JogadorID = 1;
            Jogador.Nome = "Ventura";
            Jogador.Peso = 90;
            Jogador.PosicaoID = 1;
            Jogador.UsuarioID = 1;
            Jogador.Usuario = await this.ObterUsuario(Jogador.UsuarioID);
            Jogador.Posicao = await this.ObterPosicao(Jogador.PosicaoID);



            Jogador Jogador1 = new Jogador();


            Jogador1.DataRegistro = DateTime.Now;
            Jogador1.Altura = 1.85;
            Jogador1.JogadorID = 1;
            Jogador1.Nome = "Ceni";
            Jogador1.Peso = 90;
            Jogador1.PosicaoID = 1;
            Jogador1.UsuarioID = 1;
            Jogador1.Usuario = await this.ObterUsuario(Jogador.UsuarioID);
            Jogador1.Posicao = new Models.Posicao() { PosicaoID = 1, Descricao = "Goleiro" };


            Jogadores.Add(Jogador1);



            Jogador Jogador3 = new Jogador();


            Jogador3.DataRegistro = DateTime.Now;
            Jogador3.Altura = 1.85;
            Jogador3.JogadorID = 1;
            Jogador3.Nome = "Miranda";
            Jogador3.Peso = 90;
            Jogador3.PosicaoID = 1;
            Jogador3.UsuarioID = 1;
            Jogador3.Usuario = await this.ObterUsuario(Jogador.UsuarioID);
            Jogador3.Posicao = new Models.Posicao() { PosicaoID = 2, Descricao = "Zagueiro" };

            Jogadores.Add(Jogador3);


            Jogador Jogador2 = new Jogador();


            Jogador2.DataRegistro = DateTime.Now;
            Jogador2.Altura = 1.85;
            Jogador2.JogadorID = 1;
            Jogador2.Nome = "Cafu";
            Jogador2.Peso = 90;
            Jogador2.PosicaoID = 1;
            Jogador2.UsuarioID = 1;
            Jogador2.Usuario = await this.ObterUsuario(Jogador.UsuarioID);
            Jogador2.Posicao = new Models.Posicao() { PosicaoID = 3, Descricao = "Lateral Direito" };


            Jogadores.Add(Jogador2);

            Jogador Jogador5 = new Jogador();


            Jogador5.DataRegistro = DateTime.Now;
            Jogador5.Altura = 1.85;
            Jogador5.JogadorID = 1;
            Jogador5.Nome = "Mineiro";
            Jogador5.Peso = 90;
            Jogador5.PosicaoID = 1;
            Jogador5.UsuarioID = 1;
            Jogador5.Usuario = await this.ObterUsuario(Jogador.UsuarioID);
            Jogador5.Posicao = new Models.Posicao() { PosicaoID = 5, Descricao = "Volante" };


            Jogadores.Add(Jogador5);

            Jogador Jogador6 = new Jogador();


            Jogador6.DataRegistro = DateTime.Now;
            Jogador6.Altura = 1.85;
            Jogador6.JogadorID = 1;
            Jogador6.Nome = "Junior";
            Jogador6.Peso = 90;
            Jogador6.PosicaoID = 1;
            Jogador6.UsuarioID = 1;
            Jogador6.Usuario = await this.ObterUsuario(Jogador.UsuarioID);
            Jogador6.Posicao = new Models.Posicao() { PosicaoID = 4, Descricao = "Lateral Esquerdo" };

            Jogadores.Add(Jogador6);


            Jogador Jogador4 = new Jogador();


            Jogador4.DataRegistro = DateTime.Now;
            Jogador4.Altura = 1.85;
            Jogador4.JogadorID = 1;
            Jogador4.Nome = "Junior Baiano";
            Jogador4.Peso = 90;
            Jogador4.PosicaoID = 1;
            Jogador4.UsuarioID = 1;
            Jogador4.Usuario = await this.ObterUsuario(Jogador.UsuarioID);
            Jogador4.Posicao = new Models.Posicao() { PosicaoID = 2, Descricao = "Zagueiro" };

            Jogadores.Add(Jogador4);

            Jogador Jogador7 = new Jogador();


            Jogador7.DataRegistro = DateTime.Now;
            Jogador7.Altura = 1.85;
            Jogador7.JogadorID = 1;
            Jogador7.Nome = "Kaka";
            Jogador7.Peso = 90;
            Jogador7.PosicaoID = 1;
            Jogador7.UsuarioID = 1;
            Jogador7.Usuario = await this.ObterUsuario(Jogador.UsuarioID);
            Jogador7.Posicao = new Models.Posicao() { PosicaoID = 6, Descricao = "Meio Campo" };

            Jogadores.Add(Jogador7);

            Jogador Jogador8 = new Jogador();


            Jogador8.DataRegistro = DateTime.Now;
            Jogador8.Altura = 1.85;
            Jogador8.JogadorID = 1;
            Jogador8.Nome = "Josue";
            Jogador8.Peso = 90;
            Jogador8.PosicaoID = 1;
            Jogador8.UsuarioID = 1;
            Jogador8.Usuario = await this.ObterUsuario(Jogador.UsuarioID);
            Jogador8.Posicao = new Models.Posicao() { PosicaoID = 5, Descricao = "Volante" };

            Jogadores.Add(Jogador8);

            Jogador Jogador9 = new Jogador();


            Jogador9.DataRegistro = DateTime.Now;
            Jogador9.Altura = 1.85;
            Jogador9.JogadorID = 1;
            Jogador9.Nome = "Ronaldo";
            Jogador9.Peso = 90;
            Jogador9.UsuarioID = 1;
            Jogador9.Usuario = await this.ObterUsuario(Jogador.UsuarioID);
            Jogador9.Posicao = new Models.Posicao() { PosicaoID = 7, Descricao = "Atacante" };

            Jogadores.Add(Jogador9);


            Jogador Jogador10 = new Jogador();


            Jogador10.DataRegistro = DateTime.Now;
            Jogador10.Altura = 1.85;
            Jogador10.JogadorID = 1;
            Jogador10.Nome = "Ronaldo Gaucho";
            Jogador10.Peso = 90;
            Jogador10.UsuarioID = 1;
            Jogador10.Usuario = await this.ObterUsuario(Jogador.UsuarioID);
            Jogador10.Posicao = new Models.Posicao() { PosicaoID = 6, Descricao = "Meio Campo" };

            Jogadores.Add(Jogador10);

            Jogador Jogador11 = new Jogador();


            Jogador11.DataRegistro = DateTime.Now;
            Jogador11.Altura = 1.85;
            Jogador11.JogadorID = 1;
            Jogador11.Nome = "Neymar Jr.";
            Jogador11.Peso = 90;
            Jogador11.UsuarioID = 1;
            Jogador11.Usuario = await this.ObterUsuario(Jogador.UsuarioID);
            Jogador11.Posicao = new Models.Posicao() { PosicaoID = 7, Descricao = "Atacante" };

            Jogadores.Add(Jogador11);


            return Jogadores;



        }

    }
}
