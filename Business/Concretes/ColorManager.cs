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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            
            _colorDal.Add(color);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Color color)
        {
             _colorDal.Delete(color);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult< List<Color> >GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll()); 
        }

        public IResult Update(Color color)
        {
          _colorDal.Update(color);
           return new SuccessResult(Messages.Updated);
        }
    }
}
