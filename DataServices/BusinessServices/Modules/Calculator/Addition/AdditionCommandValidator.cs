using FluentValidation;

namespace BusinessServices.Modules.CalculatorModule.Addition
{
    public class AdditionCommandValidator:AbstractValidator<AdditionCommand>
    {
        public AdditionCommandValidator()
        {
            RuleFor(x=>x.FirstOperand)
                .NotNull();
            RuleFor(x=>x.SecondOperand)
                .NotNull();
        }
    }
}