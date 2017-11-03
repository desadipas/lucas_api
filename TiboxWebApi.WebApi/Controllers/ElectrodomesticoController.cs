using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TiboxWebApi.Models;
using TiboxWebApi.UnitOfWork;

namespace TiboxWebApi.WebApi.Controllers
{
    [RoutePrefix("Electrodomestico")]
    [Authorize]
    public class ElectrodomesticoController : BaseController
    {
        public ElectrodomesticoController(IUnitOfWork unit): base (unit)
        {
        }

        [Route("Familia")]
        [HttpGet]
        public IHttpActionResult Familia()
        {
            return Ok(_unit.Electrodomestico.selFamilia());
        }

        [Route("Articulo/{nCodFamilia}")]
        [HttpGet]
        public IHttpActionResult Articulo(int nCodFamilia)
        {
            return Ok(_unit.Electrodomestico.selArticulo(nCodFamilia));
        }

        [Route("Marca/{nCodArticulo}")]
        [HttpGet]
        public IHttpActionResult Marca(int nCodArticulo)
        {
            return Ok(_unit.Electrodomestico.selMarca(nCodArticulo));
        }

        [Route("Linea")]
        [HttpPost]
        public IHttpActionResult Linea(Electrodomestico electro)
        {
            return Ok(_unit.Electrodomestico.selLinea(electro.nCodArticulo, electro.nCodMarca));
        }

        [Route("Modelo")]
        [HttpPost]
        public IHttpActionResult Modelo(Electrodomestico electro)
        {
            return Ok(_unit.Electrodomestico.selModelo(electro.nCodArticulo, electro.nCodMarca, electro.nCodLinea));
        }

        [Route("MontoElectro")]
        [HttpPost]
        public IHttpActionResult MontoElectro(Electrodomestico electro)
        {
            return Ok(_unit.Electrodomestico.selMontoMaximo(electro.nCodFamilia, electro.nCodArticulo, electro.nCodMarca, electro.nCodLinea, electro.nCodModelo));
        }

        [Route("Imagen")]
        [HttpPost]
        public IHttpActionResult Imagen(Electrodomestico electro)
        {
            var valores = new Electrodomestico();
            valores.iImagen = Convert.FromBase64String(electro.cImagen);
            valores.nCodFamilia = electro.nCodFamilia;
            valores.nCodArticulo = electro.nCodArticulo;
            valores.nCodMarca = electro.nCodMarca;
            valores.nCodLinea = electro.nCodLinea;
            valores.nCodModelo = electro.nCodModelo;
            valores.nIdFlujoMaestro = electro.nIdFlujoMaestro;
            var resultado = _unit.Electrodomestico.insImagenes(valores);

            return Ok(new { bRespuesto = resultado});
        }

        [Route("Garantia")]
        [HttpPost]
        public IHttpActionResult Garantia(Electrodomestico electro)
        {
            return Ok(_unit.Electrodomestico.insGarantia(electro));
        }

        [Route("EECC")]
        [HttpPost]
        public IHttpActionResult EECC(Electrodomestico electro)
        {
            return Ok(_unit.Electrodomestico.insEECC(electro));
        }
    }
}
