using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiboxWebApi.Models;

namespace TiboxWebApi.Repository.Interfaces
{
    public interface IElectrodomesticoRepository: IRepository<Electrodomestico>
    {
        IEnumerable<Electrodomestico> selFamilia();
        IEnumerable<Electrodomestico> selArticulo(int nCodFamilia);
        IEnumerable<Electrodomestico> selMarca(int nCodArticulo);
        IEnumerable<Electrodomestico> selLinea(int nCodArticulo, int nCodMarca);
        IEnumerable<Electrodomestico> selModelo(int nCodArticulo, int nCodMarca, int nCodLinea);
        IEnumerable<Electrodomestico> selMontoMaximo(int nCodFamilia, int nCodArticulo, int nCodMarca, int nCodLinea, int nCodModelo);
        int insImagenes(Electrodomestico electro);
        int insGarantia(Electrodomestico electro);
        int insEECC(Electrodomestico electro);
    }
}
