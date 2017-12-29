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
    public class InventarioController : ApiController
    {
        private readonly IInventarioAppServiceBase _inventarioAppServiceBase;

        public InventarioController(IInventarioAppServiceBase inventarioAppServiceBase)
        {
            _inventarioAppServiceBase = inventarioAppServiceBase;
        }

        [HttpPost()]
        public HttpResponseMessage Inserir([FromBody]InventarioViewModel inventarioViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var inventarioDomain = Mapper.Map<InventarioViewModel, Inventario>(inventarioViewModel);

                    _inventarioAppServiceBase.Add(inventarioDomain);
                    retorno = "Código de barras " + inventarioDomain.InvCodigo + "inserido com sucesso.";
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
        public HttpResponseMessage Editar([FromBody]InventarioViewModel inventarioViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var inventarioDomain = Mapper.Map<InventarioViewModel, Inventario>(inventarioViewModel);

                    _inventarioAppServiceBase.Update(inventarioDomain);
                    retorno = "Código de barras " + inventarioDomain.InvCodigo + "editado com sucesso.";
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
        public HttpResponseMessage Excluir([FromBody]InventarioViewModel inventarioViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var inventarioDomain = Mapper.Map<InventarioViewModel, Inventario>(inventarioViewModel);

                    _inventarioAppServiceBase.Remove(inventarioDomain);
                    retorno = "Código de Barras " + inventarioDomain.InvCodigo + "excluído com sucesso.";
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
            List<Inventario> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _inventarioAppServiceBase.GetAll().ToList();
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
            Inventario retorno = null;
            var formatter = new JsonMediaTypeFormatter();
            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _inventarioAppServiceBase.GetById(id);

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
        public HttpResponseMessage BuscarPorCodigo(string codigo)
        {
            List<Inventario> retorno = null;
            var formatter = new JsonMediaTypeFormatter();
            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _inventarioAppServiceBase.GetByFilter(p => p.InvCodigo == codigo).ToList();

                    if (retorno.Count == 0)
                    {
                        mensagem = "Código de barras não encontrado.";
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
        public IEnumerable<Inventario> RetornaTodosCodigos()
        {
            return _inventarioAppServiceBase.GetAll();
        }
    }
}