using System;
using System.Data.SqlClient;
using System.Data;
using TiboxWebApi.Models;
using TiboxWebApi.Repository.Interfaces;
using Dapper;

namespace TiboxWebApi.Repository.Repository
{
    public class LibroReclamacionRepository : BaseRepository<LibroReclamacion>, ILibroReclamacionRepository
    {
        public int LucasInsLibroReclamacion(LibroReclamacion libroReclamacion)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                var nvalor = 0;

                parameters.Add("@nCodPers", libroReclamacion.nCodPers);
                parameters.Add("@cDocumento", libroReclamacion.cDocumento);
                parameters.Add("@cApePat", libroReclamacion.cApePat);
                parameters.Add("@cApeMat", libroReclamacion.cApeMat);
                parameters.Add("@cNombres", libroReclamacion.cNombres);
                parameters.Add("@cContrato", libroReclamacion.cContrato);
                parameters.Add("@cDomicilioWeb", libroReclamacion.cDomicilioWeb);
                parameters.Add("@cTelefonoWeb", libroReclamacion.cTelefonoWeb);
                parameters.Add("@cEmailWeb", libroReclamacion.cEmailWeb);
                parameters.Add("@cPadres", libroReclamacion.cPadres);
                parameters.Add("@nMontoReclamado", libroReclamacion.nMontoReclamado);
                parameters.Add("@cObservaciones", libroReclamacion.cObservaciones);
                parameters.Add("@cObsPedido", libroReclamacion.cObsPedido);
                parameters.Add("@nAgenciaRespuesta", libroReclamacion.nAgenciaRespuesta);
                parameters.Add("@nTipoResp", libroReclamacion.nTipoResp);

                connection.Query<int>("WebApi_LucasInsLibroReclamaciones_SP", parameters,commandType: CommandType.StoredProcedure);
                nvalor = 1;
                return nvalor;
            }
        }
    }
}
