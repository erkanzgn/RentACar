﻿using Entites.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b=>b.BrandName).NotEmpty().MinimumLength(3);
            RuleFor(b => b.BrandId).NotEmpty();
        }
    }
}
