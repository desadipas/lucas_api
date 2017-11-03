using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using TiboxWebApi.Models;
using TiboxWebApi.Repository.Interfaces;

namespace TiboxWebApi.Repository.Repository
{
    public class AgenciaRepository : BaseRepository<Agencia>, IAgenciaRepository
    {
        public IEnumerable<Agencia> selAgenciaLibroReclamaciones()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Agencia>("WebApi_LucasAgencias_SP", null, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
