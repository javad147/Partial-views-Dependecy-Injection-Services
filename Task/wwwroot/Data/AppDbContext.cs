using Microsoft.EntityFrameworkCore;
using Task.Models;

namespace Task.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<SurpriseInfo> SurpriseInfos { get; set; }
        public DbSet<SurpriseAdvantage> SurpriseAdvantages { get; set; }
        public DbSet<SurpriseVideo> SurpriseVideos { get; set; }
        public DbSet<ExpertInfo> ExpertInfos { get; set; }
        public DbSet<Specialist> Specialists { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
