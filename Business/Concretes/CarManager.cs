using Business.Abstract;
using DataAccess.Abstract;
using Entites.Concretes;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            //gerekli sorgular
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBarandId(int id)
        {
            return _carDal.GetAll(c=>c.BrandId == id);
        }

        public List<Car> GetAllByCarId(int id)
        {
           return _carDal.GetAll(c=>c.CarId == id);           
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(c=> c.ColorId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
