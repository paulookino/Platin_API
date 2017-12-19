using AutoMapper;
using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin_WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace Platin_WebAPI.Controllers
{
    public class PrdCabController : ApiController
    {
        private readonly IPrdCabAppServiceBase _prdCabAppServiceBase;

        public PrdCabController(IPrdCabAppServiceBase
            prdCabAppServiceBase)
        {
            _prdCabAppServiceBase = prdCabAppServiceBase;
        }

        [HttpPost]
        public HttpResponseMessage Inserir(PrdCabViewModel prdCabViewModel)
        {

            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var prdCabDomain = Mapper.Map<PrdCabViewModel, PrdCab>(prdCabViewModel);

                    _prdCabAppServiceBase.Add(prdCabDomain);
                    retorno = "Produto " + prdCabDomain.Des + "inserido com sucesso.";
                }


            }
            catch (Exception ex)
            {

                retorno = "Houve um erro interno:" + ex;
            }

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, retorno);
        }

        [HttpPut]
        public HttpResponseMessage Editar(PrdCabViewModel prdCabViewModel)
        {

            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var prdCabDomain = Mapper.Map<PrdCabViewModel, PrdCab>(prdCabViewModel);

                    _prdCabAppServiceBase.Update(prdCabDomain);
                    retorno = "Produto " + prdCabDomain.Des + "editado com sucesso.";
                }

            }
            catch (Exception ex)
            {

                retorno = "Houve um erro interno:" + ex;
            }

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, retorno);
        }

        [HttpPost]
        public HttpResponseMessage Excluir(PrdCabViewModel prdCabViewModel)
        {

            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var prdCabDomain = Mapper.Map<PrdCabViewModel, PrdCab>(prdCabViewModel);

                    _prdCabAppServiceBase.Remove(prdCabDomain);
                    retorno = "Produto " + prdCabDomain.Des + "excluído com sucesso.";
                }

            }
            catch (Exception ex)
            {

                retorno = "Houve um erro interno:" + ex;
            }

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, retorno);
        }

        [HttpGet]
        public HttpResponseMessage Listar()
        {
            List<PrdCab> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _prdCabAppServiceBase.GetAll().ToList();
                }

            }
            catch (Exception ex)
            {

                erro = "Houve um erro interno:" + ex;
            }

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new { retorno, erro });
        }

        [HttpGet]
        public HttpResponseMessage BuscarPorId(int id)
        {
            PrdCab retorno = null;

            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _prdCabAppServiceBase.GetById(id);

                    if (retorno == null)
                    {
                        mensagem = "Produto por Id não encontrado.";
                    }
                }

            }
            catch (Exception ex)
            {

                mensagem = "Houve um erro interno:" + ex;
            }

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new { retorno, mensagem });
        }

        [HttpGet]
        public HttpResponseMessage BuscarPorDescricao(string des)
        {
            List<PrdCab> retorno = null;

            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _prdCabAppServiceBase.GetByFilter(p => p.Des == des).ToList();

                    if (retorno.Count == 0)
                    {
                        mensagem = "Produto por descrição não encontrado.";
                    }
                }

            }
            catch (Exception ex)
            {

                mensagem = "Houve um erro interno:" + ex;
            }


            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new { retorno, mensagem });
        }
    }
}