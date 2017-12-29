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
    public class FuncionarioController : ApiController
    {
        private readonly IFuncionarioAppServiceBase _funcionarioAppServiceBase;

        public FuncionarioController(IFuncionarioAppServiceBase funcionarioAppServiceBase)
        {
            _funcionarioAppServiceBase = funcionarioAppServiceBase;
        }

        [HttpPost()]
        public HttpResponseMessage Inserir([FromBody]FuncionarioViewModel funcionarioViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var funcionarioDomain = Mapper.Map<FuncionarioViewModel, Funcionario>(funcionarioViewModel);

                    _funcionarioAppServiceBase.Add(funcionarioDomain);
                    retorno = "Funcionário " + funcionarioDomain.FunNome + "inserido com sucesso.";
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
        public HttpResponseMessage Editar([FromBody]FuncionarioViewModel funcionarioViewModel)
        {
            var formatter = new JsonMediaTypeFormatter();
            string retorno = null;
            try
            {
                if (ModelState.IsValid)
                {
                    var funcionarioDomain = Mapper.Map<FuncionarioViewModel, Funcionario>(funcionarioViewModel);

                    _funcionarioAppServiceBase.Update(funcionarioDomain);
                    retorno = "Funcionário " + funcionarioDomain.FunNome + "editado com sucesso.";
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
                    var funcionarioDomain = _funcionarioAppServiceBase.GetById(id);

                    _funcionarioAppServiceBase.Remove(funcionarioDomain);
                    retorno = "Funcionário " + funcionarioDomain.FunNome + "excluído com sucesso.";
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
            List<Funcionario> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _funcionarioAppServiceBase.GetAll().ToList();
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
            Funcionario retorno = null;
            var formatter = new JsonMediaTypeFormatter();
            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _funcionarioAppServiceBase.GetById(id);

                    if (retorno == null)
                    {
                        mensagem = "Funcionário por Id não encontrado.";
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
            List<Funcionario> retorno = null;
            var formatter = new JsonMediaTypeFormatter();
            string mensagem = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _funcionarioAppServiceBase.GetByFilter(p => p.FunNome == nome).ToList();

                    if (retorno.Count == 0)
                    {
                        mensagem = "Funcionário não encontrado.";
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
        public IEnumerable<Funcionario> RetornaTodosFuncionarios()
        {
            return _funcionarioAppServiceBase.GetAll();
        }
    }
}