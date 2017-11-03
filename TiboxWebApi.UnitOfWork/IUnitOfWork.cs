using TiboxWebApi.Models;
using TiboxWebApi.Repository;
using TiboxWebApi.Repository.Interfaces;

namespace TiboxWebApi.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        IRepository<Product> Products { get; }
        ICatalogoCodigoRepository CatalogoCodigo { get; }
        IZonaRepository Zona { get; }
        IPersonaRepository Persona { get; }
        IFlujoRepository FlujoMaestro { get; }
        ICreditoRepository Credito { get; }
        IRepository<WebPersonaLenddo> Lenddo { get; }
        IRepository<VarNegocio> VarNegocio { get; }
        IReporteRepository Reporte { get; }
        IDocumentoRepository Documento { get; }
        IErrorRepository Error { get; }
        IReglaNegocioRepository ReglaNegocio { get; }
        IMenuRepository Menu { get; }
        ILibroReclamacionRepository LibroReclamacion { get; }
        IAgenciaRepository Agencia { get; }
        IElectrodomesticoRepository Electrodomestico { get; }
    }
}
