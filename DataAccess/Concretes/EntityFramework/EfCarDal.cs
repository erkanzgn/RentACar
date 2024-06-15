using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concretes;
using Entites.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RecapDataContext>, ICarDal
    {
        public List<CarDetailDto> GetAllCarDetails()
        {
            using (RecapDataContext context = new RecapDataContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join r in context.Colors on c.ColorId equals r.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 CarName = c.CarName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 ColorName = r.ColorName,
                                 BrandId = c.BrandId,
                                 ColorId = c.ColorId,
                                 Description = c.Description,
                                 ImagePath = (from i in context.CarImages where i.CarId == c.CarId select i.ImagePath).SingleOrDefault()
                             };

                return result.ToList();
            }
        }


        public List<CarDetailDto> GetCarDetailByBrandColorId(int colorId, int brandId)
        {
            using (RecapDataContext context = new RecapDataContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join r in context.Colors on c.ColorId equals r.ColorId
                             where c.BrandId == brandId && c.ColorId == colorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 CarName = c.CarName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 ColorName = r.ColorName,
                                 BrandId = c.BrandId,
                                 ColorId = c.ColorId,
                                 Description = c.Description,
                                 ImagePath = (from i in context.CarImages where i.CarId == c.CarId select i.ImagePath).SingleOrDefault()
                             };

                return result.ToList();
            }

        }

        public List<CarDetailDto> GetCarDetailByColorId(int colorId)
        {
            using (RecapDataContext context = new RecapDataContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join r in context.Colors on c.ColorId equals r.ColorId
                             where c.ColorId == colorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 CarName = c.CarName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 ColorName = r.ColorName,
                                 BrandId = c.BrandId,
                                 ColorId = c.ColorId,
                                 Description = c.Description,
                                 ImagePath = (from i in context.CarImages where i.CarId == c.CarId select i.ImagePath).SingleOrDefault()
                             };

                return result.ToList();
            }




        }



        public List<CarDetailDto> GetCarDetailByCarId(int carId)
        {

            using (RecapDataContext context = new RecapDataContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join r in context.Colors on c.ColorId equals r.ColorId
                             where c.CarId == carId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 CarName = c.CarName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 ColorName = r.ColorName,
                                 BrandId = c.BrandId,
                                 ColorId = c.ColorId,
                                 Description = c.Description,
                                 ImagePath = (from i in context.CarImages where i.CarId == c.CarId select i.ImagePath).SingleOrDefault()
                             };

                return result.ToList();
            }

        }
        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (RecapDataContext context = new RecapDataContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join r in context.Colors on c.ColorId equals r.ColorId
                             where c.BrandId == brandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 CarName = c.CarName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 ColorName = r.ColorName,
                                 BrandId = c.BrandId,
                                 ColorId = c.ColorId,
                                 Description = c.Description,
                                 ImagePath = (from i in context.CarImages where i.CarId == c.CarId select i.ImagePath).SingleOrDefault()
                             };

                return result.ToList();
            }

        }
    }
}
