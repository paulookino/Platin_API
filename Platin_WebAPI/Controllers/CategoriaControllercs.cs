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
    public class CategoriaController : ApiController
    {
        private readonly ICategoriaAppServiceBase _categoriaAppServiceBase;

        public CategoriaController(ICategoriaAppServiceBase categoriaAppServiceBase)
        {
            _categoriaAppServiceBase = categoriaAppServiceBase;
        }

        [HttpPost()]
        public HttpResponseMessage Inserir([FromBody]CategoriaViewModel categoriaViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var categoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(categoriaViewModel);

                    _categoriaAppServiceBase.Add(categoriaDomain);
                    retorno = "Categoria " + categoriaDomain.CatNome + "inserida com sucesso.";
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
        public HttpResponseMessage Editar([FromBody]CategoriaViewModel categoriaViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var categoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(categoriaViewModel);

                    _categoriaAppServiceBase.Update(categoriaDomain);
                    retorno = "Categoria " + categoriaDomain.CatNome + "editado com sucesso.";
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

        [HttpPost()]
        public HttpResponseMessage Excluir([FromBody]CategoriaViewModel categoriaViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var categoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(categoriaViewModel);

                    _categoriaAppServiceBase.Remove(categoriaDomain);
                    retorno = "Categoria " + categoriaDomain.CatNome + "excluído com sucesso.";
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
            List<Categoria> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _categoriaAppServiceBase.GetAll().ToList();
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
            Categoria retorno = null;
            var formatter = new JsonMediaTypeFormatter();
            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _categoriaAppServiceBase.GetById(id);

                    if (retorno == null)
                    {
                        mensagem = "Categoria por Id não encontrado.";
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
            List<Categoria> retorno = null;
            var formatter = new JsonMediaTypeFormatter();
            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _categoriaAppServiceBase.GetByFilter(p => p.CatNome == nome).ToList();

                    if (retorno.Count == 0)
                    {
                        mensagem = "Categoria não encontrada.";
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
        public IEnumerable<Categoria> RetornaTodasCategorias()
        {
            return _categoriaAppServiceBase.GetAll();
        }
    }
}