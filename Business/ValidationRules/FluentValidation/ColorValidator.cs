﻿using Entites.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = Entites.Concretes.Color;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(c=>c.ColorName).NotEmpty();
            RuleFor(c=>c.ColorId).NotEmpty();
        }
    }
}
