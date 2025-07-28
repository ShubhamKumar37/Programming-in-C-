using Microsoft.EntityFrameworkCore;

namespace EntityRelationshipDemo.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookPublisher> BookPublishers { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>((e) =>
            {
                e.HasKey(a => a.Id); // This has key will make primary key
                e.Property(a => a.Name).IsRequired();

                e.HasOne(a => a.PublisherNavigation)
                 .WithOne(p => p.AuthorNavigation)
                 .HasForeignKey<Author>(a => a.PublisherId)
                 .OnDelete(DeleteBehavior.NoAction); // This will not delete the author when publisher is deleted
            });
            modelBuilder.Entity<Book>((e) =>
            {
                e.HasKey(a => a.Id);
                e.Property(a => a.Title).IsRequired();

                e.HasOne(b => b.AuthorNavigation)
                 .WithMany(p => p.BooksNavigation)
                 .HasForeignKey(b => b.PublisherId).OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Publisher>((e) =>
            {
                e.HasKey(a => a.Id);
                e.Property(a => a.Name).IsRequired();
            });

            modelBuilder.Entity<BookPublisher>((e) =>
            {
                e.HasKey(bp => new {bp.PublisherId, bp.BookId});

                e.HasOne(bp => bp.BookNavigation)
                 .WithMany(b => b.BookPublishersNavigation)
                 .HasForeignKey(bp => bp.BookId)
                 .OnDelete(DeleteBehavior.NoAction);

                e.HasOne(bp => bp.PublisherNavigation)
                 .WithMany(p => p.BookPublishersNavigation)
                 .HasForeignKey(bp => bp.PublisherId)
                 .OnDelete(DeleteBehavior.NoAction);
            });
        }
    }
}
