
using System.Threading;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess {
    public interface IAPIContext 
    {
        DbSet<OperationHistory> OperationHistory { get; }

        int SaveChanges();
        Task<int> SaveChangesAsync();

    }
}