using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand,RecapDataContext> , IBrandDal
    {

    }
}
