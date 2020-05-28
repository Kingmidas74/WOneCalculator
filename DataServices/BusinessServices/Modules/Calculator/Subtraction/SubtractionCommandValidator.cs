using FluentValidation;

namespace BusinessServices.Modules.CalculatorModule.Subtraction
{
    public class SubtractionCommandValidator:AbstractValidator<SubtractionCommand>
    {
        public SubtractionCommandValidator()
        {
            RuleFor(x=>x.FirstOperand)
                .NotNull();
            RuleFor(x=>x.SecondOperand)
                .NotNull();
        }
    }
}