using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Domain;
using DataAccess;

namespace BusinessServices.Modules.CalculatorModule.Multiplication
{
    public class MultiplicationCommandHandler: IRequestHandler<MultiplicationCommand, double>
    {
        private readonly APIContext apiContext;

        public MultiplicationCommandHandler(APIContext apiContext)
        {
            this.apiContext=apiContext;
        }
        public async Task<double> Handle(MultiplicationCommand request, CancellationToken cancellationToken)
        {
            return await Task<double>.Factory.StartNew(()=>request.FirstOperand*request.SecondOperand, cancellationToken);
        }
    }
}