using FluentValidation;

namespace BusinessServices.Modules.CalculatorModule.Division
{
    public class DivisionCommandValidator:AbstractValidator<DivisionCommand>
    {
        public DivisionCommandValidator()
        {
            RuleFor(x=>x.FirstOperand)
                .NotNull();
            RuleFor(x=>x.SecondOperand)
                .NotNull()
                .NotEqual(0);
        }
    }
}