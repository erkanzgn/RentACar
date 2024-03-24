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
        List<Car>GetAll();
        List<Car> GetAllByBarandId(int id);
        List<Car> GetAllByColorId(int id);
        List<Car> GetAllByCarId(int id);
        List<CarDetailDto> GetCarDetails();

    }
}
