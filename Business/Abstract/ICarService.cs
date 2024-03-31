using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concretes;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>>GetAll();
        IDataResult<List<Car>> GetAllByBarandId(int id);
        IDataResult<List<Car>> GetAllByColorId(int id);
        IDataResult<Car> GetById(int id);
        IDataResult<List<CarDetailDto>> GetAllCarDetails();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
