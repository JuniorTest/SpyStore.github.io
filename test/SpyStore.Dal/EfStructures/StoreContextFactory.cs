using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace SpyStore.Dal.EfStructures
{
    public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
    {
        public StoreContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();
            var connectionString = @"Server=(LocalDB)\.;Database=SpyStore22;Trusted_Connection=True;MultipleActiveResultSets=true;";

            optionsBuilder.UseSqlServer(connectionString, options => options.EnableRetryOnFailure());
            optionsBuilder.ConfigureWarnings(warings => 
                warings.Throw(RelationalEventId.QueryClientEvaluationWarning));
            
            return new StoreContext(optionsBuilder.Options);
        }
    }
}