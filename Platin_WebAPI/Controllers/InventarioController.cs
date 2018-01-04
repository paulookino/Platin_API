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

        private readonly IProdutoAppServiceBase _produtoAppServiceBase;

        public InventarioController(IInventarioAppServiceBase inventarioAppServiceBase,
            IProdutoAppServiceBase produtoAppServiceBase)
        {
            _inventarioAppServiceBase = inventarioAppServiceBase;
            _produtoAppServiceBase = produtoAppServiceBase;
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
        public HttpResponseMessage Excluir(int id)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {


                var inventarioDomain = _inventarioAppServiceBase.GetById(id);
                    _inventarioAppServiceBase.Remove(inventarioDomain);
                    retorno = "Código de Barras " + inventarioDomain.InvCodigo + "excluído com sucesso.";
                
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



        [HttpGet]
        public IEnumerable<InventarioProduto> RetornaInventarioProduto()
        {
            var inventarioProduto = new List<InventarioProduto>();

            try
            {
                var inventario = _inventarioAppServiceBase.GetAll();


                foreach (var ip in inventario)
                {
                    var inventarioProdutoApp = _produtoAppServiceBase.GetByFilter(c => c.ProCodigo == ip.InvCodigo);


                    inventarioProduto.Add(new InventarioProduto
                    {
                        InvId = ip.InvId,
                        InvCodigo = ip.InvCodigo,
                        ProNome = inventarioProdutoApp.Count() != 0 ? inventarioProdutoApp.LastOrDefault().ProNome : "Sem nome"

                    });

                }
            }

            catch (Exception e)
            {

            }



            return inventarioProduto;
        }

        [HttpGet]
        public IEnumerable<InventarioViewModel> RetornaTodosCodigosComContagem()
        {
            var list = _inventarioAppServiceBase.GetAll();
            
            var query = list.Select(c => c.InvCodigo)
                .GroupBy(s => s)
                .Select(g => new  InventarioViewModel { InvCodigo = g.Key, ContagemCodigo = g.Count() });

            return query;
        }
    }
}