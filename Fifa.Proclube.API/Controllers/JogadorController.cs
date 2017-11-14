using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Fifa.Proclube.API.Models;
using Fifa.Proclube.Domains.Models;
using Fifa.Proclube.Domains.Repositorio;

namespace Fifa.Proclube.API.Controllers
{
    public class JogadorController : BaseController
    {
        #region Declare

        private MapperConfiguration ConfigMap;
        private IMapper iMapper;
        const string USER_NOT_VALID_MESSAGE = "Usuário ou Senha inválidos";
        const string EMAIL_NOT_VALID_MESSAGE = "E-mail não cadastrado";

        #endregion

        #region CTOR
        public JogadorController()
        {
            response = new BaseResponse();
            formatter = new JsonMediaTypeFormatter();
            responseCode = new System.Net.HttpStatusCode();

            ConfigMap = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Clube, ClubeViewModel>();
                cfg.CreateMap<ClubeViewModel, Clube>();
                cfg.CreateMap<Usuario, UsuarioViewModel>();
                cfg.CreateMap<Jogador, JogadorViewModel>();
                cfg.CreateMap<JogadorViewModel, Jogador>();
            });

            iMapper = ConfigMap.CreateMapper();
        }
        #endregion



        [HttpPost]
        [Route("CadastrarJogador")]
        public async Task<JogadorViewModel> CadastrarJogador(JogadorViewModel clube)
        {

            JogadorViewModel _jogador = new JogadorViewModel();

            try
            {


             


                //if (!ModelState.IsValid)
                //    return Request.CreateResponse(HttpStatusCode.InternalServerError);

                //var _participante = iMapper.Map<ParticipanteViewModel, Participante>(participante);

                //var returnParticipante = await _participanteRepository.RegistrarParticipante(_participante);

            }
            catch (Exception ex)
            {

                throw ex;
            }


            return clube;
        }




        [HttpPost]
        [Route("ObterJogador")]
        public async Task<JogadorViewModel> ObterJogador(int JogadorID)
        {


            JogadorViewModel _jogador = new JogadorViewModel();
            try
            {

                using (var rep = new JogadorRepository(new Domains.Infraestrutura.ProclubeContext()))
                {

                    var temp_jogador = await rep.ObterJogador(JogadorID);


                    _jogador = iMapper.Map<Jogador, JogadorViewModel >(temp_jogador);

                }
                //if (!ModelState.IsValid)
                //    return Request.CreateResponse(HttpStatusCode.InternalServerError);

                //var _participante = iMapper.Map<ParticipanteViewModel, Participante>(participante);

                //var returnParticipante = await _participanteRepository.RegistrarParticipante(_participante);

            }
            catch (Exception ex)
            {

                throw ex;
            }


            return _jogador;
        }

    }
}
