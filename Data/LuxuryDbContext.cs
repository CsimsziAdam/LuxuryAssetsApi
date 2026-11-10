using Microsoft.EntityFrameworkCore;
using LuxuryAssetsApi.Models;

namespace LuxuryAssetsApi.Data
{
    public class LuxuryDbContext : DbContext
    {
        public LuxuryDbContext(DbContextOptions<LuxuryDbContext> options) : base(options) { }

        public DbSet<Asset> Assets => Set<Asset>();
    }
}