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
    public class VFunUadCabController : ApiController
    {
        private readonly IVFunUadCabAppServiceBase _vFunUadCabAppServiceBase;

        public VFunUadCabController(IVFunUadCabAppServiceBase vFunUadCabAppServiceBase)
        {
            _vFunUadCabAppServiceBase = vFunUadCabAppServiceBase;
        }

        [HttpGet]
        public HttpResponseMessage Listar()
        {
            var formatter = new JsonMediaTypeFormatter();
            List<VFunUadCab> retorno = null;

            string erro = null;
            try
            {
                if (ModelState.IsValid)
                {
                    retorno = _vFunUadCabAppServiceBase.GetAll().ToList();
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