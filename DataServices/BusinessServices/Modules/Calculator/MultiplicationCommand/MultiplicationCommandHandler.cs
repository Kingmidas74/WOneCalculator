using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Domain;
using DataAccess;
using System;

namespace BusinessServices.Modules.CalculatorModule.Multiplication
{
    public class MultiplicationCommandHandler: IRequestHandler<MultiplicationCommand, double>
    {
        private readonly IAPIContext apiContext;

        public MultiplicationCommandHandler(IAPIContext apiContext)
        {
            this.apiContext=apiContext;
        }
        public async Task<double> Handle(MultiplicationCommand request, CancellationToken cancellationToken)
        {
            await apiContext.OperationHistory.AddAsync(new OperationHistory {
                Id=Guid.NewGuid(),
                Operation = OperationId.Multiplication,
                FirstOperand = request.FirstOperand,
                SecondOperand = request.SecondOperand
            });
            await apiContext.SaveChangesAsync();
            return request.FirstOperand*request.SecondOperand;
        }
    }
}