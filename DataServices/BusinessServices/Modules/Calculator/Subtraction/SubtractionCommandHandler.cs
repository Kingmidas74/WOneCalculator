using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Domain;
using DataAccess;
using System;

namespace BusinessServices.Modules.CalculatorModule.Subtraction
{
    public class SubtractionCommandHandler: IRequestHandler<SubtractionCommand, double>
    {
        private readonly IAPIContext apiContext;

        public SubtractionCommandHandler(IAPIContext apiContext)
        {
            this.apiContext=apiContext;
        }
        public async Task<double> Handle(SubtractionCommand request, CancellationToken cancellationToken)
        {
            await apiContext.OperationHistory.AddAsync(new OperationHistory {
                Id=Guid.NewGuid(),
                Operation = OperationId.Subtraction,
                FirstOperand = request.FirstOperand,
                SecondOperand = request.SecondOperand
            });
            await apiContext.SaveChangesAsync();
            return request.FirstOperand-request.SecondOperand;
        }
    }
}