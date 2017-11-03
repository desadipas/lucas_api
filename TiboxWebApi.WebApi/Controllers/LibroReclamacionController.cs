using System.Web.Http;
using TiboxWebApi.Models;
using TiboxWebApi.UnitOfWork;

namespace TiboxWebApi.WebApi.Controllers
{
    [RoutePrefix("LibroReclamacion")]
    [Authorize]
    public class LibroReclamacionController : BaseController
    {
        public LibroReclamacionController(IUnitOfWork unit) : base(unit)
        {
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult Post(LibroReclamacion libroReclamacion)
        {
            if (libroReclamacion == null) return BadRequest();
            return Ok(_unit.LibroReclamacion.LucasInsLibroReclamacion(libroReclamacion));
        }

    }
}
