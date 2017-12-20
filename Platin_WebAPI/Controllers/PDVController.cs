using Platin.Application.Interfaces;
using Platin.Domain.Entities;
using Platin.Infra.CrossCutting.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace Platin_WebAPI.Controllers
{
    public class PDVController : ApiController
    {
        private readonly IVFunUadCabAppServiceBase _vFunUadCabAppServiceBase;
        private readonly IUsuSisAppServiceBase _usuSisAppServiceBase;
        private readonly ILotCxaAppServiceBase _lotCxaAppServiceBase;
        private readonly IClsCabAppServiceBase _clsCabAppServiceBase;
        private readonly IPrdCabAppServiceBase _prdCabAppServiceBase;
        private readonly ICpmCabAppServiceBase _cpmCabAppServiceBase;
        private readonly ICpmIteAppServiceBase _cpmIteAppServiceBase;

        public PDVController(
            IVFunUadCabAppServiceBase vFunUadCabAppServiceBase,
            IUsuSisAppServiceBase usuSisAppServiceBase,
            ILotCxaAppServiceBase lotCxaAppServiceBase,
            IClsCabAppServiceBase clsCabAppServiceBase,
            IPrdCabAppServiceBase prdCabAppServiceBase,
            ICpmCabAppServiceBase cpmCabAppServiceBase,
            ICpmIteAppServiceBase cpmIteAppServiceBase)
        {
            _vFunUadCabAppServiceBase = vFunUadCabAppServiceBase;
            _usuSisAppServiceBase = usuSisAppServiceBase;
            _lotCxaAppServiceBase = lotCxaAppServiceBase;
            _clsCabAppServiceBase = clsCabAppServiceBase;
            _prdCabAppServiceBase = prdCabAppServiceBase;
            _cpmCabAppServiceBase = cpmCabAppServiceBase;
            _cpmIteAppServiceBase = cpmIteAppServiceBase;
        }

        [HttpGet]
        public HttpResponseMessage ConsultaVFunUadCabUsuSis()
        {
            var formatter = new JsonMediaTypeFormatter();
            List<VFunUadCabUsuSis> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    //retorno = _vFunUadCabAppServiceBase.GetAll().Select(item => new VFunUadCab).ToList();

                    retorno = _vFunUadCabAppServiceBase.ConsultaVFunUadCabUsuSis();
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
        public HttpResponseMessage ConsultaLotCxaVFunUadCab()
        {
            var formatter = new JsonMediaTypeFormatter();
            List<LotCxaVFunUadCab> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    //retorno = _vFunUadCabAppServiceBase.GetAll().Select(item => new VFunUadCab).ToList();

                    retorno = _lotCxaAppServiceBase.ConsultaLotCxaVFunUadCab();
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
        public HttpResponseMessage ConsultaClsCab()
        {
            var formatter = new JsonMediaTypeFormatter();
            List<ClsCab> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    //retorno = _vFunUadCabAppServiceBase.GetAll().Select(item => new VFunUadCab).ToList();

                    retorno = _clsCabAppServiceBase.GetAll().Select(item => new ClsCab
                    {
                        Cod = item.Cod,
                        Des = item.Des
                    }).ToList();
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
        public HttpResponseMessage ConsultaPrdCabPrdBarCpmIte()
        {
            var formatter = new JsonMediaTypeFormatter();
            List<PrdCabPrdBarCpmIte> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    //retorno = _vFunUadCabAppServiceBase.GetAll().Select(item => new VFunUadCab).ToList();

                    retorno = _prdCabAppServiceBase.ConsultaPrdCabPrdBarCpmIte();
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
        public HttpResponseMessage ConsultaCpmCabLotCxaFunCabCpmFec()
        {
            var formatter = new JsonMediaTypeFormatter();
            List<CpmCabLotCxaFunCabCpmFec> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    //retorno = _vFunUadCabAppServiceBase.GetAll().Select(item => new VFunUadCab).ToList();

                    retorno = _cpmCabAppServiceBase.ConsultaCpmCabLotCxaFunCabCpmFec();
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
        public HttpResponseMessage ConsultaCpmIteCpmCab()
        {
            var formatter = new JsonMediaTypeFormatter();
            List<CpmIteCpmCab> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    //retorno = _vFunUadCabAppServiceBase.GetAll().Select(item => new VFunUadCab).ToList();

                    retorno = _cpmIteAppServiceBase.ConsultaCpmIteCpmCab();
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
        public HttpResponseMessage ConsultaCpmCabPrdCabCpmIte()
        {
            var formatter = new JsonMediaTypeFormatter();
            List<CpmCabPrdCabCpmIte> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    //retorno = _vFunUadCabAppServiceBase.GetAll().Select(item => new VFunUadCab).ToList();

                    retorno = _cpmCabAppServiceBase.ConsultaCpmCabPrdCabCpmIte();
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
    }
}