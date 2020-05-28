using MediatR;

namespace BusinessServices.Modules.CalculatorModule.Multiplication
{
    public class MultiplicationCommand:IRequest<double>
    {
        public double FirstOperand {get; set;}
        public double SecondOperand {get; set;}
    }
}