using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Domain;
using DataAccess;
using System;

namespace BusinessServices.Modules.CalculatorModule.Addition
{
    public class AdditionCommandHandler: IRequestHandler<AdditionCommand, double>
    {
        private readonly IAPIContext apiContext;

        public AdditionCommandHandler(IAPIContext apiContext)
        {
            this.apiContext=apiContext;
        }
        public async Task<double> Handle(AdditionCommand request, CancellationToken cancellationToken)
        {
            await apiContext.OperationHistory.AddAsync(new OperationHistory {
                Id=Guid.NewGuid(),
                Operation = OperationId.Addition,
                FirstOperand = request.FirstOperand,
                SecondOperand = request.SecondOperand
            });
            await apiContext.SaveChangesAsync();
            return request.FirstOperand+request.SecondOperand;
        }
    }
}