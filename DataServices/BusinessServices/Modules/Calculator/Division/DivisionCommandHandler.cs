using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Domain;
using DataAccess;

namespace BusinessServices.Modules.CalculatorModule.Division
{
    public class DivisionCommandHandler: IRequestHandler<DivisionCommand, double>
    {
        private readonly APIContext apiContext;

        public DivisionCommandHandler(APIContext apiContext)
        {
            this.apiContext=apiContext;
        }
        public async Task<double> Handle(DivisionCommand request, CancellationToken cancellationToken)
        {
            return await Task<double>.Factory.StartNew(()=>request.FirstOperand/request.SecondOperand, cancellationToken);
        }
    }
}