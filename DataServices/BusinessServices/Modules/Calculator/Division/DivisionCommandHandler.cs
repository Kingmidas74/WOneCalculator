using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Domain;
using DataAccess;
using System;

namespace BusinessServices.Modules.CalculatorModule.Division
{
    public class DivisionCommandHandler: IRequestHandler<DivisionCommand, double>
    {
        private readonly IAPIContext apiContext;

        public DivisionCommandHandler(IAPIContext apiContext)
        {
            this.apiContext=apiContext;
        }
        public async Task<double> Handle(DivisionCommand request, CancellationToken cancellationToken)
        {
            await apiContext.OperationHistory.AddAsync(new OperationHistory {
                Id=Guid.NewGuid(),
                Operation = OperationId.Division,
                FirstOperand = request.FirstOperand,
                SecondOperand = request.SecondOperand
            });
            await apiContext.SaveChangesAsync();
            return request.FirstOperand/request.SecondOperand;
        }
    }
}