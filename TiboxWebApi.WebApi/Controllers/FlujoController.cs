using System.Web.Http;
using TiboxWebApi.Models;
using TiboxWebApi.UnitOfWork;

namespace TiboxWebApi.WebApi.Controllers
{
    [RoutePrefix("Flujo")]
    [Authorize]
    public class FlujoController : BaseController
    {
        public FlujoController(IUnitOfWork unit) : base(unit)
        {
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult Post(FlujoMaestro flujo)
        {
            if (flujo == null) return BadRequest();
            var resultado = _unit.FlujoMaestro.LucasRegistraFlujo(flujo);
            if (resultado == 0) return BadRequest();
            return Ok(new { bResultado = resultado });
        }

        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult DevuelveFlujo(int id)
        {
            if (id == 0) return BadRequest();
            return Ok(_unit.FlujoMaestro.LucasRecuperaFlujo(id));
        }

        [Route("Solicitud/{id}")]
        [HttpGet]
        public IHttpActionResult DevuelveDatosSolicitud(int id)
        {
            if (id == 0) return BadRequest();
            return Ok(_unit.FlujoMaestro.LucasRecuperaSolicitud(id));
        }

        [Route("Wizard/{id}")]
        [HttpGet]
        public IHttpActionResult Wizard(int id)
        {
            if (id == 0) return BadRequest();
            return Ok(_unit.FlujoMaestro.ObtieneWizard(id));
        }

        [Route("Eliminar")]
        [HttpPost]
        public IHttpActionResult Eliminar(FlujoMaestro flujo)
        {
            return Ok(_unit.FlujoMaestro.EliminaFlujo(flujo));
        }

        [Route("MotivoRechazado/{nIdFlujoMaestro}")]
        [HttpGet]
        public IHttpActionResult MotivoRechazado(int nIdFlujoMaestro)
        {
            return Ok(_unit.FlujoMaestro.MotivoRechazado(nIdFlujoMaestro));
        }

        [Route("Ocultar/{id}")]
        [HttpGet]
        public IHttpActionResult Ocultar(int id)
        {
            return Ok(_unit.FlujoMaestro.OcultarFlujo(id));
        }

        [Route("Electro")]
        [HttpPost]
        public IHttpActionResult Electro(FlujoMaestro flujo)
        {
            if (flujo == null) return BadRequest();
            var resultado = _unit.FlujoMaestro.ElectroRegistraFlujo(flujo);
            if (resultado == 0) return BadRequest();
            return Ok(new { bResultado = resultado });
        }

        [Route("ElectroSolicitud/{id}")]
        [HttpGet]
        public IHttpActionResult ElectroSolicitud(int id)
        {
            return Ok(_unit.FlujoMaestro.ElectroRecuperaFlujo(id));
        }
    }
}
