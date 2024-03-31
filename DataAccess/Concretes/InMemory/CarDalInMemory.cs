using DataAccess.Abstract;
using Entites;
using Entites.Concretes;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory;

public class CarDalInMemory : ICarDal
{
    //List<Car> _cars;

    //public CarDalInMemory()
    //{
    //    _cars = new List<Car> 
    //    {
    //     new Car {Id=1,ColorId=1,BarandId=1,DailyPrice=1000000,Description="Sedan",ModelYear=2020},
    //     new Car {Id=2,ColorId=1,BarandId=1,DailyPrice=3500000,Description="SUV",ModelYear=2021 },
    //     new Car {Id=3,ColorId=2,BarandId=2,DailyPrice=4600000,Description="Sport Sedan ",ModelYear=2023 },
    //     new Car {Id=4,ColorId=2,BarandId=2,DailyPrice=1200000,Description="Hatchback",ModelYear=2019 },
    //     new Car {Id=5,ColorId=3,BarandId=3,DailyPrice=2000000,Description="Sedan",ModelYear=2020 },
    //     new Car {Id=6,ColorId=4,BarandId=3,DailyPrice=1700000,Description="Sedan",ModelYear=2020 }
    //    };

    //}

    //public void Add(Car car)
    //{
    //   _cars.Add(car);
    //}

    //public void Delete(Car car)
    //{
    //    Car DeletedCar=_cars.SingleOrDefault(car=>car.Id==car.Id);
    //    _cars.Remove(DeletedCar); 
    //}

    //public List<Car> GetAll()
    //{
    //    return _cars;
    //}

    //public List<Car> GetById(int id)
    //{ 
    //   var result= _cars.Where(c=>c.Id==id).ToList();
    //    return result;
    //}

    //public void Update(Car car)
    //{
    //    Car CarToUpdate = _cars.FirstOrDefault(car=>car.Id==car.Id);
    //    CarToUpdate.DailyPrice = car.DailyPrice;
    //    CarToUpdate.Description = car.Description;
    //    CarToUpdate.ModelYear = car.ModelYear;
    //    CarToUpdate.BarandId = car.BarandId;
    //    CarToUpdate.ColorId= car.ColorId;
    //}
    public void Add(Car entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Car entity)
    {
        throw new NotImplementedException();
    }

    public Car Get(Expression<Func<Car, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public List<CarDetailDto> GetAllCarDetails()
    {
        throw new NotImplementedException();
    }

    public void Update(Car entity)
    {
        throw new NotImplementedException();
    }
}
