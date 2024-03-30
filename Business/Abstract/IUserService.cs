using Core.Utilities.Results;
using Entites.Concretes;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
