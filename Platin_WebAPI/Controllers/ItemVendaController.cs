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
    public class ItemVendaController : ApiController
    {
        private readonly IItemVendaAppServiceBase _itemVendaAppServiceBase;

        public ItemVendaController(IItemVendaAppServiceBase itemVendaAppServiceBase)
        {
            _itemVendaAppServiceBase = itemVendaAppServiceBase;
        }

        [HttpPost()]
        public HttpResponseMessage Inserir([FromBody]ItemVendaViewModel itemVendaViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var itemVendaDomain = Mapper.Map<ItemVendaViewModel, ItemVenda>(itemVendaViewModel);

                    _itemVendaAppServiceBase.Add(itemVendaDomain);
                    retorno = "Item da Venda " + itemVendaDomain.IteId + "inserido com sucesso.";
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
        public HttpResponseMessage Editar([FromBody]ItemVendaViewModel itemVendaViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var itemVendaDomain = Mapper.Map<ItemVendaViewModel, ItemVenda>(itemVendaViewModel);

                    _itemVendaAppServiceBase.Update(itemVendaDomain);
                    retorno = "Item da Venda " + itemVendaDomain.IteId + "editado com sucesso.";
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
                    var itemVendaDomain = _itemVendaAppServiceBase.GetById(id);

                    _itemVendaAppServiceBase.Remove(itemVendaDomain);
                    retorno = "Item da Venda " + itemVendaDomain.IteId + "excluído com sucesso.";
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
            List<ItemVenda> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _itemVendaAppServiceBase.GetAll().ToList();
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
            ItemVenda retorno = null;
            var formatter = new JsonMediaTypeFormatter();
            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _itemVendaAppServiceBase.GetById(id);

                    if (retorno == null)
                    {
                        mensagem = "Item da Venda por Id não encontrado.";
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
        public HttpResponseMessage BuscarPorInformacao(string informacao)
        {
            List<ItemVenda> retorno = null;
            var formatter = new JsonMediaTypeFormatter();
            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _itemVendaAppServiceBase.GetByFilter(p => p.IteInformacao == informacao).ToList();

                    if (retorno.Count == 0)
                    {
                        mensagem = "Item de Venda não encontrado.";
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
        public IEnumerable<ItemVenda> RetornaTodosItemVenda()
        {
            return _itemVendaAppServiceBase.GetAll();
        }
    }
}