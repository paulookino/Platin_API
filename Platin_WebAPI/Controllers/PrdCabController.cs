using AutoMapper;
using Newtonsoft.Json.Serialization;
using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Infra.CrossCutting.Helpers;
using Platin_WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
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
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var prdCabDomain = Mapper.Map<PrdCabViewModel, PrdCab>(prdCabViewModel);

                    _prdCabAppServiceBase.Add(prdCabDomain);
                    retorno = "Produto " + prdCabDomain.Des + "inserido com sucesso.";
                }

                var jsonSerialize = new JsonSerialize();
                jsonSerialize.SerializarJson(formatter);

            }
            catch (Exception ex)
            {

                retorno = "Houve um erro interno:" + ex;
            }

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, retorno, formatter);
        }

        [HttpPut]
        public HttpResponseMessage Editar(PrdCabViewModel prdCabViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var prdCabDomain = Mapper.Map<PrdCabViewModel, PrdCab>(prdCabViewModel);

                    _prdCabAppServiceBase.Update(prdCabDomain);
                    retorno = "Produto " + prdCabDomain.Des + "editado com sucesso.";
                }
               
                var jsonSerialize = new JsonSerialize();
                jsonSerialize.SerializarJson(formatter);
            }
            catch (Exception ex)
            {

                retorno = "Houve um erro interno:" + ex;
            }

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, retorno, formatter);
        }

        [HttpPost]
        public HttpResponseMessage Excluir(PrdCabViewModel prdCabViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var prdCabDomain = Mapper.Map<PrdCabViewModel, PrdCab>(prdCabViewModel);

                    _prdCabAppServiceBase.Remove(prdCabDomain);
                    retorno = "Produto " + prdCabDomain.Des + "excluído com sucesso.";
                }
                
                var jsonSerialize = new JsonSerialize();
                jsonSerialize.SerializarJson(formatter);

            }
            catch (Exception ex)
            {

                retorno = "Houve um erro interno:" + ex;
            }

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, retorno, formatter);
        }

        [HttpGet]
        public HttpResponseMessage Listar()
        {
            List<PrdCab> retorno = null;
            var formatter = new JsonMediaTypeFormatter();
            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _prdCabAppServiceBase.GetAll().ToList();
                }

                var jsonSerialize = new JsonSerialize();

                jsonSerialize.SerializarJson(formatter);
            }
            catch (Exception ex)
            {

                erro = "Houve um erro interno:" + ex;
            }

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new { retorno, erro }, formatter);
        }

        [HttpGet]
        public HttpResponseMessage BuscarPorId(int id)
        {
            PrdCab retorno = null;
            var formatter = new JsonMediaTypeFormatter();
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
                var jsonSerialize = new JsonSerialize();

                jsonSerialize.SerializarJson(formatter);
            }
            catch (Exception ex)
            {

                mensagem = "Houve um erro interno:" + ex;
            }

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new { retorno, mensagem }, formatter);
        }

        [HttpGet]
        public HttpResponseMessage BuscarPorDescricao(string des)
        {
            List<PrdCab> retorno = null;
            var formatter = new JsonMediaTypeFormatter();
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
                var jsonSerialize = new JsonSerialize();

                jsonSerialize.SerializarJson(formatter);

            }
            catch (Exception ex)
            {

                mensagem = "Houve um erro interno:" + ex;
            }


            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new { retorno, mensagem }, formatter);
        }
    }
}