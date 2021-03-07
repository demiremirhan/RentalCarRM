using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.BrandName).MinimumLength(2);
            RuleFor(p => p.BrandName).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(10);
            //RuleFor(p => p.BrandName).Must(StartWitA);

        }

        //private bool StartWitA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
