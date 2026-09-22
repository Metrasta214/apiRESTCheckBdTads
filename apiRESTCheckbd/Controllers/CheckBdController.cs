using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//-------------------------------------------------
using Newtonsoft.Json.Linq;
using apiRESTCheckbd.Models;
//-------------------------------------------------

using apiRESTCheckBdTads.Models;
using Newtonsoft.Json.Linq;
using System.Web.Http;

namespace apiRESTCheckBdTads.Controllers
{
    public class CheckBdController : ApiController
    {
        [HttpGet]
        [Route("check/checkbd/mysqlconectioncheckbd")]
        public clsApiStatus mysqlConectionCheckBd()
        {
            // -------------------------------------
            clsApiStatus objRespuesta =
                new clsApiStatus();

            JObject jsonResp =
                new JObject();

            // -------------------------------------
            // Ejecución del método de conexión

            clsCheckBd objCheckBd =
                new clsCheckBd();

            objCheckBd.checkBd();

            // -------------------------------------
            // Validar resultado

            if (objCheckBd.ban == 1)
            {
                objRespuesta.statusExec = true;
            }
            else
            {
                objRespuesta.statusExec = false;
            }

            // -------------------------------------

            objRespuesta.ban =
                objCheckBd.ban;

            objRespuesta.msg =
                objCheckBd.statusMsg;

            jsonResp.Add(
                "msgData",
                objCheckBd.statusMsg
            );

            objRespuesta.datos =
                jsonResp;

            return objRespuesta;
        }
    }
}