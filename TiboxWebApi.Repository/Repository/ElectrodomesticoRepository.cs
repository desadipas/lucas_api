using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiboxWebApi.Models;
using TiboxWebApi.Repository.Interfaces;
using Dapper;

namespace TiboxWebApi.Repository.Repository
{
    public class ElectrodomesticoRepository : BaseRepository<Electrodomestico>, IElectrodomesticoRepository
    {
        public IEnumerable<Electrodomestico> selFamilia()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Electrodomestico>("WebApi_ElectroFamilia_SP", null, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Electrodomestico> selArticulo(int nCodFamilia)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@nCodFamilia", nCodFamilia);
                return connection.Query<Electrodomestico>("WebApi_ElectroArticulo_SP", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Electrodomestico> selMarca(int nCodArticulo)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@nCodArticulo", nCodArticulo);
                return connection.Query<Electrodomestico>("WebApi_ElectroMarca_SP", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Electrodomestico> selLinea(int nCodArticulo, int nCodMarca)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@pnCodArticulo", nCodArticulo);
                parameters.Add("@pnCodMarca", nCodMarca);
                return connection.Query<Electrodomestico>("WebApi_ElectroLinea_SP", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Electrodomestico> selModelo(int nCodArticulo, int nCodMarca, int nCodLinea)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@pnCodArticulo", nCodArticulo);
                parameters.Add("@pnCodMarca", nCodMarca);
                parameters.Add("@pnCodLinea", nCodLinea);
                return connection.Query<Electrodomestico>("WebApi_ElectroModelo_SP", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Electrodomestico> selMontoMaximo(int nCodFamilia, int nCodArticulo, int nCodMarca, int nCodLinea, int nCodModelo)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@nCodFamilia", nCodFamilia);
                parameters.Add("@nCodArticulo", nCodArticulo);
                parameters.Add("@nCodMarca", nCodMarca);
                parameters.Add("@nCodLinea", nCodLinea);
                parameters.Add("@nCodModelo", nCodModelo);
                return connection.Query<Electrodomestico>("WebApi_ElectroValorTasado_SP", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public int insImagenes(Electrodomestico electro)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var resultado = 0;
                var parameters = new DynamicParameters();
                parameters.Add("@nIdFlujoMaestro", electro.nIdFlujoMaestro);
                parameters.Add("@nCodFamilia", electro.nCodFamilia);
                parameters.Add("@nCodArticulo", electro.nCodArticulo);
                parameters.Add("@nCodMarca", electro.nCodMarca);
                parameters.Add("@nCodLinea", electro.nCodLinea);
                parameters.Add("@nCodModelo", electro.nCodModelo);
                parameters.Add("@oFotografia", electro.iImagen);
                connection.Query<int>("WebApi_ElectroSubirImagenes_SP", parameters, commandType: CommandType.StoredProcedure);
                resultado = 1;
                return resultado;
            }
        }

        public int insGarantia(Electrodomestico electro)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var resultado = 0;
                var parameters = new DynamicParameters();
                parameters.Add("@nCodAge", electro.nCodAge);
                parameters.Add("@oXml", electro.cXML);
                parameters.Add("@nIdFlujoMaestro", electro.nIdFlujoMaestro);
                parameters.Add("@nProd", electro.nProd);
                parameters.Add("@nSubProd", electro.nSubProd);
                parameters.Add("@cNomForm", electro.cNomForm);
                parameters.Add("@cUsuReg", electro.cUsuReg);
                parameters.Add("@nCodPersReg", electro.nCodPersReg);
                parameters.Add("@nIdFlujo", electro.nIdFlujo);
                parameters.Add("@nOrdenFlujo", electro.nOrdenFlujo);
                connection.Query<int>("WebApi_ElectroGarantia_SP", parameters, commandType: CommandType.StoredProcedure);
                resultado = 1;
                return resultado;
            }
        }

        public int insEECC(Electrodomestico electro)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@nCodPers", electro.nCodPers);
                parameters.Add("@nCodAge", electro.nCodAge);
                parameters.Add("@nCodCred", electro.nCodCred);
                parameters.Add("@nEnvioEstado", electro.nEnvioEstado);
                parameters.Add("@nProd", electro.nProd);
                parameters.Add("@nSubProd", electro.nSubProd);
                parameters.Add("@nIdFlujoMaestro", electro.nIdFlujoMaestro);
                parameters.Add("@cNomForm", electro.cNomForm);
                parameters.Add("@cUsuReg", electro.cUsuReg);
                parameters.Add("@nCodPersReg", electro.nCodPersReg);
                parameters.Add("@nIdFlujo", electro.nIdFlujo);
                parameters.Add("@nOrdenFlujo", electro.nOrdenFlujo);
                parameters.Add("@nRetornoExistoso" ,dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Query<int>("WebApi_ElectroEECC_SP", parameters, commandType: CommandType.StoredProcedure);
                return parameters.Get<int>("@nRetornoExistoso");
            }
        }
    }
}
