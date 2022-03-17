using Microsoft.EntityFrameworkCore;
using Xaero.DataLayer.Entities;
using Xaero.DataLayer.Mappers;

namespace Xaero.DataLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentMapper());
        }
    }
}
