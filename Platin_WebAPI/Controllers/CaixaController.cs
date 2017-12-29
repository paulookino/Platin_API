using AutoMapper;
using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Infra.CrossCutting.Helpers;
using Platin_WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Results;

namespace Platin_WebAPI.Controllers
{
    public class CaixaController : ApiController
    {
        private readonly ICaixaAppServiceBase _caixaAppServiceBase;

        public CaixaController(ICaixaAppServiceBase caixaAppServiceBase)
        {
            _caixaAppServiceBase = caixaAppServiceBase;
        }

        [HttpPost()]
        public HttpResponseMessage Inserir([FromBody]CaixaViewModel caixaViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var caixaDomain = Mapper.Map<CaixaViewModel, Caixa>(caixaViewModel);

                    _caixaAppServiceBase.Add(caixaDomain);
                    retorno = "Caixa " + caixaDomain.CaiNumero + "inserido com sucesso.";
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

        [HttpPut()]
        public HttpResponseMessage Editar([FromBody]CaixaViewModel caixaViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var caixaDomain = Mapper.Map<CaixaViewModel, Caixa>(caixaViewModel);

                    _caixaAppServiceBase.Update(caixaDomain);
                    retorno = "Caixa " + caixaDomain.CaiNumero + "editado com sucesso.";
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

        [HttpDelete()]
        public HttpResponseMessage Excluir(int id)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var caixaDomain = _caixaAppServiceBase.GetById(id);

                    _caixaAppServiceBase.Remove(caixaDomain);
                    retorno = "Caixa " + caixaDomain.CaiNumero + "excluído com sucesso.";
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
            var formatter = new JsonMediaTypeFormatter();
            List<Caixa> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _caixaAppServiceBase.GetAll().ToList();
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
            Caixa retorno = null;
            var formatter = new JsonMediaTypeFormatter();
            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _caixaAppServiceBase.GetById(id);

                    if (retorno == null)
                    {
                        mensagem = "Caixa por Id não encontrado.";
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
        public HttpResponseMessage BuscarPorNumero(int numero)
        {
            List<Caixa> retorno = null;
            var formatter = new JsonMediaTypeFormatter();
            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _caixaAppServiceBase.GetByFilter(p => p.CaiNumero == numero).ToList();

                    if (retorno.Count == 0)
                    {
                        mensagem = "Caixa não encontrado.";
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
        public IEnumerable<Caixa> RetornaTodosCaixas()
        {
            return _caixaAppServiceBase.GetAll();
        }
    }
}