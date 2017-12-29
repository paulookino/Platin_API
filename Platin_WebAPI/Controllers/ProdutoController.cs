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
    public class ProdutoController : ApiController
    {
        private readonly IProdutoAppServiceBase _produtoAppServiceBase;

        public ProdutoController(IProdutoAppServiceBase produtoAppServiceBase)
        {
            _produtoAppServiceBase = produtoAppServiceBase;
        }

        [HttpPost()]
        public HttpResponseMessage Inserir([FromBody]ProdutoViewModel produtoViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);

                    _produtoAppServiceBase.Add(produtoDomain);
                    retorno = "Produto " + produtoDomain.ProNome + "inserido com sucesso.";
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
        public HttpResponseMessage Editar([FromBody]ProdutoViewModel produtoViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);

                    _produtoAppServiceBase.Update(produtoDomain);
                    retorno = "Produto " + produtoDomain.ProNome + "editado com sucesso.";
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
        public HttpResponseMessage Excluir([FromBody]ProdutoViewModel produtoViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);

                    _produtoAppServiceBase.Remove(produtoDomain);
                    retorno = "Produto " + produtoDomain.ProNome + "excluído com sucesso.";
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
            List<Produto> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _produtoAppServiceBase.GetAll().ToList();
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
            Produto retorno = null;
            var formatter = new JsonMediaTypeFormatter();
            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _produtoAppServiceBase.GetById(id);

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
        public HttpResponseMessage BuscarPorNome(string nome)
        {
            List<Produto> retorno = null;
            var formatter = new JsonMediaTypeFormatter();
            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _produtoAppServiceBase.GetByFilter(p => p.ProNome == nome).ToList();

                    if (retorno.Count == 0)
                    {
                        mensagem = "Produto não encontrado.";
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
        public IEnumerable<Produto> RetornaTodosProdutos()
        {
            return _produtoAppServiceBase.GetAll();
        }
    }
}