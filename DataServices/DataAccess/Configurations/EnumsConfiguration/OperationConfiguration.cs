using System;
using System.Linq;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess
{
    class OperationConfiguration : IEntityTypeConfiguration<Operation>
    {
        public virtual void Configure(EntityTypeBuilder<Operation> builder)
        {
            builder.HasData (
                Enum.GetValues (typeof (OperationId))
                .Cast<OperationId> ()
                .Select (e => new Operation () {
                        OperationId = e,
                        Value = e.ToString ()
                })
            );    
        }
    }
}