using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concretes;
using Entites.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RecapDataContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RecapDataContext context =new RecapDataContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands                           
                             on c.BrandId equals  b.BrandId
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             select new CarDetailDto {CarId=c.CarId,BrandName=b.BrandName,CarName=c.CarName,ModelYear=c.ModelYear , DailyPrice=c.DailyPrice ,ColorName=r.ColorName};

                return result.ToList();
            }
        }
    }
}
