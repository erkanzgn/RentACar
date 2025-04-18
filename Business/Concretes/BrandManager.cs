﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
        
            _brandDal.Add(brand);
            return new SuccessResult (Messages.Added);
        }

        public IResult Delete(Brand brand)
        {
       
            _brandDal.Delete(brand);
            return new SuccessResult (Messages.Deleted);
        }

        public IDataResult< List<Brand>> GetAll()
        {
   
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IResult Update(Brand brand)
        {
  
            _brandDal.Update(brand);
            return new SuccessResult(Messages.Updated);
        }
    }
}
