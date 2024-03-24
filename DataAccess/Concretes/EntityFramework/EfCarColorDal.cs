using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCarColorDal : EfEntityRepositoryBase<CarColor ,RecapDataContext>,ICarColorDal
    {

    }
}
