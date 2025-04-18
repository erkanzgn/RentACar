﻿using Entites.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            //RuleFor(c => c.CarId).NotEmpty();
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty().GreaterThanOrEqualTo(2000).When(c=>c.BrandId==1);
            RuleFor(c => c.BrandId).NotEmpty();
        }
    }
}
