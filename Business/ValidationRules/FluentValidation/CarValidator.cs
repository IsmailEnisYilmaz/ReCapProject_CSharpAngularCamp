using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c=>c.ModelYear).NotEmpty();
            RuleFor(c=>c.DailyPrice).NotEmpty();
            RuleFor(c=>c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(100000).When(c => c.BrandId == 1);
            RuleFor(c => c.Description).Must(StartWithB).WithMessage("Araç markası B harfi ile başlamalı.");
        }

        private bool StartWithB(string arg)
        {
            return arg.StartsWith("B");
        }
    }
}
