﻿using Entites.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c=>c.UserId).NotEmpty();
            RuleFor(c=>c.CompanyName).NotEmpty().MinimumLength(2);
            RuleFor(c => c.CustomerId).NotEmpty();
        }
    }
}
