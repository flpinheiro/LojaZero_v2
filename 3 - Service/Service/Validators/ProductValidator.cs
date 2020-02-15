using FluentValidation;
using LojaZero.Domain.Entity;
using System;

namespace LojaZero.Service.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x => throw new ArgumentNullException($"Can't found the object."));

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Is necessary to inform product name")
                .NotNull().WithMessage("Is necessary to inform product name");
        }
    }
}
