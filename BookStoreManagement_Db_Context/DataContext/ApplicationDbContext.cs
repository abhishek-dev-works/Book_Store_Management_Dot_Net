using Microsoft.EntityFrameworkCore;

namespace BookStoreManagement_Db_Context.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User>? Users { get; set; } = null;
        public DbSet<Book>? Books { get; set; } = null;
        public DbSet<Record>? Records { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One-to-Many: User → Records
            modelBuilder.Entity<Record>()
                .HasOne(r => r.User)
                .WithMany(u => u.Records)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // One-to-Many: Book → Records
            modelBuilder.Entity<Record>()
                .HasOne(r => r.Book)
                .WithMany(b => b.Records)
                .HasForeignKey(r => r.BookId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
