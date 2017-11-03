using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TiboxWebApi.UnitOfWork;

namespace TiboxWebApi.WebApi.Controllers
{
    [RoutePrefix("Agencia")]
    public class AgenciaController : BaseController
    {
        public AgenciaController(IUnitOfWork unit) : base(unit)
        {
        }

        [Route("")]
        [HttpGet]
        public IHttpActionResult SelAgencias()
        {
            return Ok(_unit.Agencia.selAgenciaLibroReclamaciones());
        }
    }
}
