using MediatR;

namespace BusinessServices.Modules.CalculatorModule.Division
{
    public class DivisionCommand:IRequest<double>
    {
        public double FirstOperand {get; set;}
        public double SecondOperand {get; set;}
    }
}