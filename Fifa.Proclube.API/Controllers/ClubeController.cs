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
    public class ClubeController  : BaseController

    {
        #region Declare

        private MapperConfiguration ConfigMap;
        private IMapper iMapper;
        const string USER_NOT_VALID_MESSAGE = "Usuário ou Senha inválidos";
        const string EMAIL_NOT_VALID_MESSAGE = "E-mail não cadastrado";

        #endregion

        #region CTOR
        public ClubeController()
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
        [Route("CadastrarClube")]
        public async Task<ClubeViewModel> CadastrarClube(ClubeViewModel clube)
        {

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



        [HttpGet]
        [Route("ObterClube")]
        public async Task<ClubeViewModel> ObterClube(int ClubeID)
        {

            ClubeViewModel club = new ClubeViewModel();
            try
            {

              

                //if (!ModelState.IsValid)
                //    return Request.CreateResponse(HttpStatusCode.InternalServerError);

                //var _participante = iMapper.Map<ParticipanteViewModel, Participante>(participante);

                //var returnParticipante = await _participanteRepository.RegistrarParticipante(_participante);

                using(var Rep = new ClubeRepository(new Domains.Infraestrutura.ProclubeContext())){


                    var clube_temp = await Rep.ObterClube(ClubeID);


                    club = iMapper.Map<Clube, ClubeViewModel>(clube_temp);

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }


            return club;
        }


        [HttpGet]
        [Route("ObterClube")]
        public async Task<List<JogadorViewModel>> ObterElenco(int ClubeID)
        {

            List<JogadorViewModel> Elenco = new List<JogadorViewModel>();
            try
            {



                //if (!ModelState.IsValid)
                //    return Request.CreateResponse(HttpStatusCode.InternalServerError);

                //var _participante = iMapper.Map<ParticipanteViewModel, Participante>(participante);

                //var returnParticipante = await _participanteRepository.RegistrarParticipante(_participante);

                using (var Rep = new ClubeRepository(new Domains.Infraestrutura.ProclubeContext()))
                {


                    var Elenco_temp = await Rep.ObterElenco(ClubeID);


                    Elenco = iMapper.Map<List<Jogador>, List<JogadorViewModel>>(Elenco_temp);

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }


            return Elenco;
        }


    }
}
