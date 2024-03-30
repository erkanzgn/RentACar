using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer,RecapDataContext> ,ICustomerDal
    {
    }
}
