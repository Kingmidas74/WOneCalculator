using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess
{
    class OperationHistoryConfiguration : IEntityTypeConfiguration<OperationHistory>
    {
        public virtual void Configure(EntityTypeBuilder<OperationHistory> builder)
        {
            builder.Property(e=>e.Operation)
                    .HasConversion<int> ();
        }
    }
}