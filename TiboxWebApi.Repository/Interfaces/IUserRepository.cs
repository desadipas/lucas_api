using System.Collections.Generic;
using TiboxWebApi.Models;

namespace TiboxWebApi.Repository.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User ValidateUser(string email, string password);
        User validateUserElectro(string userName, string password);
        User validateUserAD(string userName, string password);
        IEnumerable<User> LucasVerificaEmail(string cEmail);
        IEnumerable<Persona> LucasDatosLogin(string cEmail);
        int LucasCambiaPass(string email, string password);
        int selCambioPass(int nCodPers);
    }
}
