using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Domain;
using DataAccess;

namespace BusinessServices.Modules.CalculatorModule.Subtraction
{
    public class SubtractionCommandHandler: IRequestHandler<SubtractionCommand, double>
    {
        private readonly APIContext apiContext;

        public SubtractionCommandHandler(APIContext apiContext)
        {
            this.apiContext=apiContext;
        }
        public async Task<double> Handle(SubtractionCommand request, CancellationToken cancellationToken)
        {
            return await Task<double>.Factory.StartNew(()=>request.FirstOperand-request.SecondOperand, cancellationToken);
        }
    }
}