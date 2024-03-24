using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;
using Entites.Concretes;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
        
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName+" "+car.BrandName+" "+car.ModelYear+" "+car.ColorName);
            }
            
      

        }
    }
}
