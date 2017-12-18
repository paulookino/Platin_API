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
    public class ProductController : ApiController
    {
        private readonly IProductAppServiceBase _productAppServiceBase;

        public ProductController(IProductAppServiceBase 
            productAppServiceBase)
        {
            _productAppServiceBase = productAppServiceBase;
        }

        [HttpPost]
        public HttpResponseMessage Inserir(ProductViewModel productModel)
        {

            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var productDomain = Mapper.Map<ProductViewModel, Product>(productModel);

                    _productAppServiceBase.Add(productDomain);
                    retorno = "Produto "+ productDomain.Name + "inserido com sucesso.";
                }


            }
            catch (Exception ex)
            {

                retorno = "Houve um erro interno:" + ex;
            }

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, retorno);
        }

        [HttpPut]
        public HttpResponseMessage Editar(ProductViewModel productModel)
        {

            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var productDomain = Mapper.Map<ProductViewModel, Product>(productModel);

                    _productAppServiceBase.Update(productDomain);
                    retorno = "Produto " + productDomain.Name + "editado com sucesso.";
                }

            }
            catch (Exception ex)
            {

                retorno = "Houve um erro interno:" + ex;
            }

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, retorno);
        }

        [HttpPost]
        public HttpResponseMessage Excluir(ProductViewModel productModel)
        {

            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var productDomain = Mapper.Map<ProductViewModel, Product>(productModel);

                    _productAppServiceBase.Remove(productDomain);
                    retorno = "Produto " + productDomain.Name + "excluído com sucesso.";
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
            List<Product> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _productAppServiceBase.GetAll().ToList();
                }

            }
            catch (Exception ex)
            {
                
                erro = "Houve um erro interno:" + ex;
            }

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new{ retorno, erro });
        }

        [HttpGet]
        public HttpResponseMessage BuscarPorId(int id)
        {
            Product retorno = null;

            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _productAppServiceBase.GetById(id);

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
        public HttpResponseMessage BuscarPorNome(string name)
        {
            List<Product> retorno = null;

            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _productAppServiceBase.GetByFilter(p => p.Name == name).ToList();

                    if (retorno.Count == 0)
                    {
                        mensagem = "Produto por nome não encontrado.";
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