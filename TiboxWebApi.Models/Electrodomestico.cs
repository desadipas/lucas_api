using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiboxWebApi.Models
{
    public class Electrodomestico
    {
        public int nCodFamilia { get; set; }
        public int nCodArticulo { get; set; }
        public int nCodMarca { get; set; }
        public int nCodLinea { get; set; }
        public int nCodModelo { get; set; }
        public int nCodigo { get; set; }
        public string cDescripcion { get; set; }
        public double nMontoTasado { get; set; }
        public double nMonto { get; set; }
        public double nPorcentajeValTas { get; set; }
        public string cImagen { get; set; }
        public byte[] iImagen { get; set; }
        public int nIdFlujoMaestro { get; set; }
        public int nCodAge { get; set; }
        public string cXML { get; set; }
        public int nProd { get; set; }
        public int nSubProd { get; set; }
        public string cNomForm { get; set; }
        public string cUsuReg { get; set; }
        public int nCodPersReg { get; set; }
        public int nIdFlujo { get; set; }
        public int nOrdenFlujo { get; set; }
        public int nCodPers { get; set; }
        public int nCodCred { get; set; }
        public int nEnvioEstado { get; set; }
    }
}
