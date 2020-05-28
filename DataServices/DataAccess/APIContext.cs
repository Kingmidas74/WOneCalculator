using System;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess {
    public class APIContext : DbContext,IAPIContext {
        private string SchemaName { get; set; } = "public";

        public DbSet<OperationHistory> OperationHistory { get; set; }
        public APIContext (DbContextOptions<APIContext> options) : base (options) { }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.HasDefaultSchema (schema: SchemaName);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(APIContext).Assembly);
            base.OnModelCreating (modelBuilder);
        }

        public override int SaveChanges () {
            AddAuitInfo ();
            return base.SaveChanges ();
        }

        public async Task<int> SaveChangesAsync () {
            AddAuitInfo ();
            return await base.SaveChangesAsync ();
        }

        private void AddAuitInfo () {
            var entries = ChangeTracker.Entries ().Where (x => x.Entity is IEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in entries) {
                if (entry.State == EntityState.Added) {
                    ((IEntity) entry.Entity).CreatedDate = DateTime.UtcNow;
                    ((IEntity) entry.Entity).Status = EntityStatusId.Active;
                }
                ((IEntity) entry.Entity).ModifiedDate = DateTime.UtcNow;
            }
        }
    }
}