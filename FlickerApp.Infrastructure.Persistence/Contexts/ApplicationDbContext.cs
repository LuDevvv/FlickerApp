using FlickerApp.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlickerApp.Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define the table names
            modelBuilder.Entity<Comment>().ToTable("Comments");
            modelBuilder.Entity<Friend>().ToTable("Friends");
            modelBuilder.Entity<Publication>().ToTable("Publications");
            modelBuilder.Entity<User>().ToTable("Users");

            // Define primary keys
            modelBuilder.Entity<Comment>().HasKey(c => c.CommentId);
            modelBuilder.Entity<Friend>().HasKey(f => f.FriendId);
            modelBuilder.Entity<Publication>().HasKey(p => p.PublicationId);
            modelBuilder.Entity<User>().HasKey(u => u.UserId);

            // Define relationships
            modelBuilder.Entity<Publication>()
                .HasMany(p => p.Comments)
                .WithOne(c => c.Publication)
                .HasForeignKey(c => c.PublicationId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Publications)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Friends)
                .WithOne(f => f.User)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Friends)
                .WithOne(f => f.User)
                .HasForeignKey(f => f.FriendUserId);
        }
    }
}
