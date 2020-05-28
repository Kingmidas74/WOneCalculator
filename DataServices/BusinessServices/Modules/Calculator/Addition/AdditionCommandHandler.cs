using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Domain;
using DataAccess;

namespace BusinessServices.Modules.CalculatorModule.Addition
{
    public class AdditionCommandHandler: IRequestHandler<AdditionCommand, double>
    {
        private readonly APIContext apiContext;

        public AdditionCommandHandler(APIContext apiContext)
        {
            this.apiContext=apiContext;
        }
        public async Task<double> Handle(AdditionCommand request, CancellationToken cancellationToken)
        {
            return await Task<double>.Factory.StartNew(()=>request.FirstOperand+request.SecondOperand, cancellationToken);
        }
    }
}