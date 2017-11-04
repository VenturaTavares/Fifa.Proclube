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
    public class CampeonatoController : BaseController
    {
        #region Declare

        private MapperConfiguration ConfigMap;
        private IMapper iMapper;
        const string USER_NOT_VALID_MESSAGE = "Usuário ou Senha inválidos";
        const string EMAIL_NOT_VALID_MESSAGE = "E-mail não cadastrado";

        #endregion

        #region CTOR
        public CampeonatoController()
        {
            response = new BaseResponse();
            formatter = new JsonMediaTypeFormatter();
            responseCode = new System.Net.HttpStatusCode();

            ConfigMap = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Clube, ClubeViewModel>();
                cfg.CreateMap<ClubeViewModel, Clube>();
   
                cfg.CreateMap<Campeonato, CampeonatoViewModel>();
                cfg.CreateMap<CampeonatoViewModel, Campeonato>();

            });

            iMapper = ConfigMap.CreateMapper();
        }
        #endregion


        [HttpPost]
        [Route("CadastrarCampeonato")]
        public async Task<CampeonatoViewModel> CadastrarCampeonato(CampeonatoViewModel clube)
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


        [HttpPost]
        [Route("CadastrarClubeEmCampeonato")]
        public async Task<bool> CadastrarClubeEmCampeonato(int campeonatoID, int ClubeID)
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


            return true;
        }


        [HttpGet]
        [Route("ObterCampeonato")]
        public async Task<CampeonatoViewModel> ObterCampeonato(int campeonatoID)
        {

            CampeonatoViewModel camp = new CampeonatoViewModel();

            try
            {

                using(var Rep = new CampeonatoRepositorio(new Domains.Infraestrutura.ProclubeContext())){


                  var camp_temp =  await Rep.ObterCampeonato(campeonatoID);


                    camp = iMapper.Map<Campeonato,CampeonatoViewModel>(camp_temp);

                    //var _participante = iMapper.Map<ParticipanteViewModel, Participante>(participante);

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


            return camp;
        }


        [HttpGet]
        [Route("ObterCampeonato")]
        public async Task<List<ClubeViewModel>> ObterClubesDoCampeonato(int campeonatoID)
        {

            List<ClubeViewModel> Clubes = new List<ClubeViewModel>();

            try
            {

                using (var Rep = new CampeonatoRepositorio(new Domains.Infraestrutura.ProclubeContext()))
                {


                    var clube_temp = await Rep.ObterClubesPartcipantes(campeonatoID);


                    Clubes = iMapper.Map<List<Clube>,List<ClubeViewModel>>(clube_temp);


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


            return Clubes;
        }


    }
}
