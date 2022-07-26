using FluentValidation;

namespace CleanArchitecture.Application.InputModels.Validations
{
    public class CarInputModelValidator : AbstractValidator<CarInputModel>
    {
        public CarInputModelValidator()
        {
            RuleFor(x => x.Name)
              .NotEmpty()
              .WithMessage("{PropertyName} is required");

            RuleFor(x => x.Model)
              .NotEmpty()
              .WithMessage("{PropertyName} is required");
        }
    }
}
