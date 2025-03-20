using Microsoft.EntityFrameworkCore;

namespace BookStoreManagement_Db_Context.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User>? Users { get; set; } = null;
        public DbSet<Book>? Books { get; set; } = null;
        public DbSet<Record>? Entries { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
