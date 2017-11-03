using System.Collections.Generic;
using TiboxWebApi.Models;

namespace TiboxWebApi.Repository.Interfaces
{
    public interface ICreditoRepository : IRepository<Credito>
    {
        IEnumerable<Credito> LucasBandeja(int nCodPers, int nPagina, int nTam, int nCodAge);
        int LucasInsCredito(Credito credito);
        int LucasInsModalidad(Credito credito);
        IEnumerable<Credito> LucasDatosPrestamo(int nCodAge, int nCodCred);
        int LucasInsFirmaElectronica(Credito credito);
        IEnumerable<Credito> LucasCalendarioLista(int nCodAge, int nCodCred);
        IEnumerable<Credito> LucasKardexLista(int nCodAge, int nCodCred);
        int LucasRechazadoPorDia(string cDocumento);
        int LucasCreditoEnFlujo(string cDocumento);
        int LucasCreditoAnulaxActualizacion(string cDocumento);
        IEnumerable<Credito> ElectroBandejaCredito(int nCodPersReg, string cTitular,string cDocumento, int nCodAge, int nNumPag, int nTamPag);
        int ElectroInsCredito(Credito credito);
    }
}
