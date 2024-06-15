using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concretes;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RecapDataContext>, IRentalDal
    {
        public List<RentalDetailDto> GetAllRentalDetail()
        {
            using ( RecapDataContext context = new RecapDataContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join s in context.Customers
                             on r.CustomerId equals s.CustomerId
                             join u in context.Users
                             on s.UserId equals u.Id
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new RentalDetailDto
                             {
                                 Id=r.RentalId,
                                 CarId = c.CarId,
                                 BrandName=b.BrandName,
                                 CustomerName=u.FirstName+" "+u.LastName,
                                 DailyPrice = c.DailyPrice,
                                 RentDate= r.RentDate,
                                 ReturnDate= r.ReturnDate,
                                 CustomerId= s.CustomerId,
                             };


                return result.ToList();

            }
        }
    }
}
