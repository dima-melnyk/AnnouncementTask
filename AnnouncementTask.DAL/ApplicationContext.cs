using AnnouncementTask.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AnnouncementTask.DAL
{
    class ApplicationContext : DbContext
    {
        public DbSet<Announcement> Announcements { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Announcement>()
                .HasKey(a => a.Id);
        }
    }
}
