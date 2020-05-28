using FluentValidation;

namespace BusinessServices.Modules.CalculatorModule.Multiplication
{
    public class MultiplicationCommandValidator:AbstractValidator<MultiplicationCommand>
    {
        public MultiplicationCommandValidator()
        {
            RuleFor(x=>x.FirstOperand)
                .NotNull();
            RuleFor(x=>x.SecondOperand)
                .NotNull();
        }
    }
}