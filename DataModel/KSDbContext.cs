using System;
using Microsoft.EntityFrameworkCore;

namespace DataModel
{
    public class KSDbContext : DbContext
    {
        public virtual DbSet<Pod> PodKnowledge { get; set; }

        public KSDbContext(DbContextOptions<KSDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pod>(entity =>
                entity.HasKey(o => o.Id));
            modelBuilder.Entity<Pod>(entity =>
                entity.HasIndex(o => o.Name).IsUnique(true));

        }
    }
}
