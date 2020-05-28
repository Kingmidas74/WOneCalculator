using System.Collections.Generic;
using Domain;
using MediatR;

namespace BusinessServices.Modules.HistoryModule
{
    public class GetAllHistoryQuery:IRequest<IEnumerable<OperationHistory>>
    {
    }
}