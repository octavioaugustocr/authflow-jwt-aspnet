using AuthFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthFlow.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>(entity => entity.HasKey(u => u.IdUser));

            modelBuilder.Entity<UserModel>
        }
    }
}
