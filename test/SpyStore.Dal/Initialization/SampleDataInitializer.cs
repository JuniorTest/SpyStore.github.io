using System.Linq;
using Microsoft.EntityFrameworkCore;
using SpyStore.Dal.EfStructures;
using SpyStore.Models.Entities;

namespace SpyStore.Dal.Initialization
{
    public static class SampleDataInitializer
    {
        public static void DropAndCreateDatabase(StoreContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.Migrate();
        }
    }
}