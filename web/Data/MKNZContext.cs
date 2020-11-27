using Microsoft.EntityFrameworkCore;
using web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace web.Data
{
    public class MKNZContext : IdentityDbContext<ApplicationUser>
    {
        public MKNZContext(DbContextOptions<MKNZContext> options) : base(options)
        {
        }

        public DbSet<User> MemberUsers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Band> Bands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Reservation>().ToTable("Reservation");
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<Media>().ToTable("Media");
            modelBuilder.Entity<Band>().ToTable("Band");
        }
    }
}