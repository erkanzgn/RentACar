using Core.Entities.Concretes;
using Core.Utilities.Results;
using Entites.Concretes;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
