﻿using Core.Entities.Concretes;
using Entites.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().MinimumLength(3);
            RuleFor(u => u.LastName).NotEmpty().MinimumLength(2);
            //RuleFor(u => u.Password).MinimumLength(8).NotEmpty();
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.UserId).NotEmpty();

        }
    }
}
