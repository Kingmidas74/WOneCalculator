using MediatR;

namespace BusinessServices.Modules.CalculatorModule.Subtraction
{
    public class SubtractionCommand:IRequest<double>
    {
        public double FirstOperand {get; set;}
        public double SecondOperand {get; set;}
    }
}