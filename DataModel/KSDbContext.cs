using System;
using Microsoft.EntityFrameworkCore;

namespace DataModel
{
    public class KSDbContext : DbContext
    {
        public DbSet<Pod> Pods { get; }

        public KSDbContext(DbContextOptions<KSDbContext> options)
            : base(options)
        {

        }
    }
}
