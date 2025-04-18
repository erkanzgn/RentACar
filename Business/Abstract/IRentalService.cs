﻿using Core.Utilities.Results;
using Entites.Concretes;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IDataResult <List<RentalDetailDto>>GetAllRentalDetail();
        //IDataResult<RentalDetailDto> GetRentalDetail(int id);
        IDataResult<List<Rental>>GetAll();
        IDataResult<Rental> GetById(int id);
    }
}
