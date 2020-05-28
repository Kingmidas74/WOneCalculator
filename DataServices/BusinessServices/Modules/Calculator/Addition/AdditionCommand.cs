using MediatR;

namespace BusinessServices.Modules.CalculatorModule.Addition
{
    public class AdditionCommand:IRequest<double>
    {
        public double FirstOperand {get; set;}
        public double SecondOperand {get; set;}
    }
}