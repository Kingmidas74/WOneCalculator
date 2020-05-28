using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Domain;
using DataAccess;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusinessServices.Modules.HistoryModule
{
    public class GetAllHistoryQueryHandler: IRequestHandler<GetAllHistoryQuery, IEnumerable<OperationHistory>>
    {
        private readonly IAPIContext apiContext;

        public GetAllHistoryQueryHandler(IAPIContext apiContext)
        {
            this.apiContext=apiContext;
        }
        public async Task<IEnumerable<OperationHistory>> Handle(GetAllHistoryQuery request, CancellationToken cancellationToken)
        {
            return await this.apiContext.OperationHistory.ToListAsync();
        }
    }
}