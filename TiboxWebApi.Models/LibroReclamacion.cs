using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiboxWebApi.Models
{
    public class LibroReclamacion
    {
        public int nCodPers { get; set; }
        public string cDocumento { get; set; }
        public string cApePat { get; set; }
        public string cApeMat { get; set; }
        public string cNombres { get; set; }
        public string cContrato { get; set; }
        public string cDomicilioWeb { get; set; }
        public string cTelefonoWeb { get; set; }
        public string cEmailWeb { get; set; }
        public string cPadres { get; set; }
        public double nMontoReclamado { get; set; }
        public string cObservaciones { get; set; }
        public string cObsPedido { get; set; }
        public int nAgenciaRespuesta { get; set; }
        public int nTipoResp { get; set; }
    }
}
